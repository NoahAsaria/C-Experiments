using System.Net.Http;
using System.Net.Security;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using HTTPClientSingletonNS;
using System.Net.Http.Headers;
using KaggleAuthenticatorNS;
using System.ComponentModel;

//Implementing steps from https://www.kaggle.com/discussions/general/52093 in a class format
namespace KaggleRequestorNS {
    class KaggleRequestor {
        KaggleAuthenticator _authenticator;
        public KaggleRequestor(KaggleAuthenticator authenticator) {
            _authenticator = authenticator;
        }

        public string rawKaggleAPICall(string kaggleQueryString) {
            string baseAPIURL = this._authenticator.baseAPIAddress;
            string fullQueryPath = baseAPIURL + kaggleQueryString;
            Console.WriteLine(fullQueryPath);
            var getTask = this._authenticator.getHttpClient().GetStringAsync(fullQueryPath);
            string result = getTask.Result;
            return result;
        }
        public JsonObject listKaggleDatasetFiles(string kaggleQueryString) {
            string result = rawKaggleAPICall(kaggleQueryString);
            var result_json = Json(result);
            Console.WriteLine(result_json.files);
        }

    }
}