//Reference: https://jeremyparnell.com/blog/best-practices-for-consuming-an-api/
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization; //Serialization refers to converting an object into a more transmissible form

namespace KaggleDataModelsNS;


[DataContract]
public class KaggleDatasetListingModel {
    [DataMember(Name="datasetRefNullable")]
    public string? DatasetRefNullable { get; set; }
    [DataMember(Name ="ownerRefNullable")]
    public string? OwnerRefNullable;
    [DataMember(Name = "nameNullable")]
    public string? NameNullable { get; set; }
    [DataMember(Name ="descriptionNullable")]
    public string? DescriptionNullable { get; set; }
    [DataMember(Name="fileTypeNullable")]
    public string? FileTypeNullable { get; set; }
    [DataMember(Name="urlNullable")]
    public string? UrlNullable { get; set; }
    [DataMember(Name ="ref")] //How to override this?
    public string? Ref { get; set; }
    [DataMember(Name="datasetRef")]
    public string? DatasetRef { get; set; }
    [DataMember(Name="hasDatasetRef")]
    public bool HasDatasetRef { get; set; }
    [DataMember(Name="ownerRef")]
    public string? OwnerRef { get; set; }
    [DataMember(Name="hasOwnerRef")]
    public bool HasOwnerRef { get; set; }
    [DataMember(Name ="name")]
    public string? Name { get; set; }

    [DataMember(Name="hasName")]
    public bool HasName { get; set; }
    [DataMember(Name="url")]
    public DateTime CreationDate { get; set; }
    [DataMember(Name="description")]
    public string? Description { get; set; }
    [DataMember(Name ="hasDescription")]
    public bool HasDescription { get; set; }
    [DataMember(Name ="fileType")]
    public string? FileType { get; set; }
    [DataMember(Name ="hasFileType")]
    public bool HasFileType { get; set; }
    [DataMember(Name ="totalBytes")]
    public string? Url { get; set; }
    [DataMember(Name ="hasUrl")]
    public bool HasUrl { get; set; }
    [DataMember(Name ="creationDate")]
    public long TotalBytes { get; set; }
    [DataMember(Name ="columns")]
    public List<string>? Columns { get; set; }
}

[DataContract]
public class KaggleDatasetListingRootModel {
    [DataMember(Name ="errorMessageNullable")]
    public bool ErrorMessageNullable { get; set; }
    [DataMember(Name ="nextPageTokenNullable")]
    public bool NextPageTokenNullable { get; set; }
    [DataMember(Name ="datasetFiles")]
    public List<KaggleDatasetListingModel>? DatasetFiles { get; set; }
    [DataMember(Name ="errorMessage")]
    public string? ErrorMessage { get; set; }
    [DataMember(Name ="hasErrorMessage")]
    public bool HasErrorMessage { get; set; }
    [DataMember(Name ="nextPageToken")]
    public string? NextPageToken { get; set; }
    [DataMember(Name ="hasNextPageToken")]
    public bool HasNextPageToken { get; set; }
}