using System.Net.Http;
using System.Net.Security;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using HTTPClientSingletonNS;
using System.Net.Http.Headers;

//Implementing steps from https://www.kaggle.com/discussions/general/52093 in a class format
namespace KaggleAuthenticatorNS {
    class KaggleAuthenticator {
        static HttpClient httpClient = new HttpClient();
        private string? _authToken; //Unpacked authentication token
        private string _baseAPIAddress; //Url to access
        private string _pathToKaggleAuthJSON; //Where to get the .json auth file
        public KaggleAuthenticator(string baseAPIAddress, string pathToKaggleAuthJSON) {
            _baseAPIAddress = baseAPIAddress;
            _pathToKaggleAuthJSON = pathToKaggleAuthJSON;
            setAuthToken();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _authToken);
        }
        private void setAuthToken() {
            Dictionary<string, string> authParams = new Dictionary<string, string>();
            //var authParams = new { Username = string.Empty, Key = string.Empty }; //Anonymous typing
            using (var reader = new StreamReader(_pathToKaggleAuthJSON)) {
                var json = reader.ReadToEnd();
                authParams = JsonSerializer.Deserialize<Dictionary<string,string>>(json);
                Console.Write(authParams.ToString());
            }
            //Set intermediate authParams var
            var authToken = "";
            if (authParams is not null) {
                authToken = Convert.ToBase64String(
                    System.Text.ASCIIEncoding.ASCII.GetBytes(
                        string.Format($"{authParams["Username"]}:{authParams["Key"]}", authParams)
                    )
                );
            }
            _authToken = authToken;
        }
        //TODO add setters/getters
        public string baseAPIAddress {
            get { return _baseAPIAddress; }
            set { _baseAPIAddress = value; }
        }

        public HttpClient getHttpClient() {
            return httpClient;
        }

    }
}