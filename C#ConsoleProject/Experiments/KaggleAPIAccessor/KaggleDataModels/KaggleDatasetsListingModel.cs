//Reference: https://jeremyparnell.com/blog/best-practices-for-consuming-an-api/
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization; //Serialization refers to converting an object into a more transmissible form

namespace KaggleDataModelsNS;


[DataContract]
public class KaggleDatasetListingModel {
    [DataMember(Name="datasetRefNullable")]
    public string? datasetRefNullable { get; set; }
    [DataMember(Name ="ownerRefNullable")]
    public string? ownerRefNullable;
    [DataMember(Name = "nameNullable")]
    public string? nameNullable { get; set; }
    [DataMember(Name ="descriptionNullable")]
    public string? descriptionNullable { get; set; }
    [DataMember(Name="fileTypeNullable")]
    public string? fileTypeNullable { get; set; }
    [DataMember(Name="urlNullable")]
    public string? urlNullable { get; set; }
    [DataMember(Name ="ref")] //How to override this?
    public string? @ref { get; set; }
    [DataMember(Name="datasetRef")]
    public string? datasetRef { get; set; }
    [DataMember(Name="hasDatasetRef")]
    public bool? hasDatasetRef { get; set; }
    [DataMember(Name="ownerRef")]
    public string? ownerRef { get; set; }
    [DataMember(Name="hasOwnerRef")]
    public bool? hasOwnerRef { get; set; }
    [DataMember(Name ="name")]
    public string? name { get; set; }

    [DataMember(Name="hasName")]
    public bool? hasName { get; set; }
    [DataMember(Name="creationDate")]

    public DateTime creationDate { get; set; }
    [DataMember(Name="description")]
    public string? description { get; set; }
    [DataMember(Name ="hasDescription")]
    public bool? hasDescription { get; set; }
    [DataMember(Name ="fileType")]
    public string? fileType { get; set; }
    [DataMember(Name ="hasFileType")]
    public bool? hasFileType { get; set; }
    [DataMember(Name ="url")]
    public string? url { get; set; }
    [DataMember(Name ="hasUrl")]
    public bool? hasUrl { get; set; }
    [DataMember(Name ="totalBytes")]
    public long? totalBytes { get; set; }
    [DataMember(Name ="columns")]
    public List<string>? columns { get; set; }
}

[DataContract]
public class KaggleDatasetListingRootModel {
    [DataMember(Name ="errorMessageNullable")]
    public bool? errorMessageNullable { get; set; }
    [DataMember(Name ="nextPageTokenNullable")]
    public bool? nextPageTokenNullable { get; set; }
    [DataMember(Name ="datasetFiles")]
    public List<KaggleDatasetListingModel>? datasetFiles { get; set; }
    [DataMember(Name ="errorMessage")]
    public string? errorMessage { get; set; }
    [DataMember(Name ="hasErrorMessage")]
    public bool? hasErrorMessage { get; set; }
    [DataMember(Name ="nextPageToken")]
    public string? nextPageToken { get; set; }
    [DataMember(Name ="hasNextPageToken")]
    public bool? hasNextPageToken { get; set; }
}