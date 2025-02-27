namespace KaggleAPIAccessor.KaggleDataModels;

public class KaggleDatasetListingModel {
    public string? nameNullable { get; }
    public string? descriptionNullable { get; }
    public string? urlNullable { get; }
    public string? _ref { get; }
    public string? name { get; }
    public bool hasName { get; }
    public string? description { get; }
    public bool hasDescription { get; }
    public string? url { get; }
    public bool hasUrl { get; }
    public DateTime creationDate { get; }
    
}