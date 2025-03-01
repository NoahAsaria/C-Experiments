public static class KaggleDataPath {
    public static string kaggleBasePath = "https://www.kaggle.com/api/v1/";
    public static string datasetsBasePath = "datasets";
    public static string getDatasetFileListingsPath(string author, string dataset_name) {
        return datasetsBasePath + "/list/" + author + "/" + dataset_name;
    }
}