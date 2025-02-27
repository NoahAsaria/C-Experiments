using System;
using KaggleAuthenticatorNS;
using KaggleRequestorNS;
class ExperimentalProgram {
    static int Main(string[] args) {
        string baseAPIURL = "https://www.kaggle.com/api/v1/";
        string directory = @"/Users/Work/Documents/Technical Projects 2025/CSharpExperiment/C#ConsoleProject/";
        
        string relativePathToKaggleAuthJSON = "auth/kaggle_auth.json";
        string pathToKaggleAuthJSON = directory + relativePathToKaggleAuthJSON;
        var kaggleAuth = new KaggleAuthenticator(baseAPIURL, pathToKaggleAuthJSON);
        var kaggleRequestor = new KaggleRequestor(kaggleAuth);
        kaggleRequestor.listKaggleDatasetFiles("datasets/list/martinellis/nhl-game-data");
        return 0;
    }
    
}
