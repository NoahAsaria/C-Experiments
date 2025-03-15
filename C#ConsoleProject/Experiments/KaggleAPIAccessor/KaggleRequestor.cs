using System.Net.Http;
using System.Net.Security;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using HTTPClientSingletonNS;
using System.Net.Http.Headers;
using KaggleAuthenticatorNS;
using System.ComponentModel;
using KaggleDataModelsNS;
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
            Task<string> getTask = this._authenticator.getHttpClient().GetStringAsync(fullQueryPath);
            string result = getTask.Result;
            Console.WriteLine(result);
            return result;
        }
        public KaggleDatasetListingRootModel listKaggleDatasetListings(string kaggleQueryString) {
            string result = rawKaggleAPICall(kaggleQueryString);
            var kaggleDatasetListing = JsonSerializer.Deserialize<KaggleDatasetListingRootModel>(result);
            if (kaggleDatasetListing != null) {
                Console.WriteLine(kaggleDatasetListing.ToString());
            }
            else {
                kaggleDatasetListing = new KaggleDatasetListingRootModel();
            }
            return kaggleDatasetListing;
        }   

        public void downloadKaggleDataset(string kaggleQueryString) {
            string result = rawKaggleAPICall(kaggleQueryString);
        }

    }
}