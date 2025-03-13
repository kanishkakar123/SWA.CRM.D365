using SWA.CRM.D365.Common.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace SWA.CRM.D365.Common.Services
{
    public enum AuthorizationType { AuthToken, AppKey }
    public enum RequestMethod { GET, POST }

    public static class ServiceInvocation
    {
        public static AccessToken GenerateAuthToken(string apiKey, string apiSecret, string baseUrlToken)
        {
            AccessToken accessToken;
            HttpClient authTokenClient = new HttpClient();

            try
            {
                var requestUri = new Uri($"{baseUrlToken}");

                var credentials = Encoding.ASCII.GetBytes($"{apiKey}:{apiSecret}");
                authTokenClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));

                var request = new HttpRequestMessage(HttpMethod.Post, requestUri);
                var collection = new List<KeyValuePair<string, string>>();
                collection.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
                var content = new FormUrlEncodedContent(collection);
                request.Content = content;

                var task = Task.Run(() => authTokenClient.SendAsync(request));
                task.Wait();
                var response = task.Result;

                accessToken = JsonConvert.DeserializeObject<AccessToken>(response.Content.ReadAsStringAsync().Result);

                if (!response.IsSuccessStatusCode && accessToken != null && !string.IsNullOrEmpty(accessToken.error))
                {
                    throw new Exception($"An error has occurred in the Service while generating access token - {accessToken.error} : {accessToken.error_description}");
                }

                return accessToken;
            }
            catch (Exception exception)
            {
                throw new Exception("An error has occurred in the Service while generating access token - Please contact your system administrator.", exception);
            }
        }

        public static T ServiceRequest<T>(RequestMethod requestMethod, AuthorizationType authorizationType, string requestURL, AccessToken accessToken = null, string appKey = null, object postObject = null)
        {
            T serviceResponse = default(T);
            HttpClient httpClient = new HttpClient();

            switch (authorizationType)
            {
                case AuthorizationType.AuthToken:

                    if (accessToken == null || string.IsNullOrEmpty(accessToken.access_token))
                    {
                        throw new Exception("Access Token cannot be empty.");
                    }

                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(accessToken.token_type, accessToken.access_token);
                    break;

                case AuthorizationType.AppKey:

                    if (string.IsNullOrEmpty(appKey))
                    {
                        throw new Exception("App Key cannot be empty.");
                    }

                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("AppKey", appKey);
                    break;
            }

            switch (requestMethod)
            {
                case RequestMethod.GET:
                    serviceResponse = GetRequest<T>(httpClient, requestURL);
                    break;

                case RequestMethod.POST:

                    if (postObject == null)
                    {
                        throw new Exception("Post data cannot be empty.");
                    }

                    serviceResponse = PostRequest<T>(httpClient, requestURL, postObject);
                    break;
            }

            return serviceResponse;
        }

        private static T GetRequest<T>(HttpClient httpClient, string requestURL)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, new Uri(requestURL));

                var task = Task.Run(() => httpClient.SendAsync(request));
                task.Wait();
                var response = task.Result;

                T serviceResponse = JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
                return serviceResponse;
            }
            catch (Exception exception)
            {
                throw new Exception("ERROR: An error has occurred in the Service GET Request - Please contact your system administrator.", exception);
            }
        }

        private static T PostRequest<T>(HttpClient httpClient, string requestURL, object postObject)
        {
            try
            {
                var requestUri = new Uri(requestURL);

                var content = new StringContent(JsonConvert.SerializeObject(postObject));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var task = Task.Run(() => httpClient.PostAsync(requestUri, content));
                task.Wait();
                var response = task.Result;

                T postResponse = JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
                return postResponse;
            }
            catch (Exception exception)
            {
                throw new Exception("ERROR: An error has occurred in the Service POST Request - Please contact your system administrator.", exception);
            }
        }
    }
}
