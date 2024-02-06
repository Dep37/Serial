using System.Text.Json;
using System.Text.Json.Serialization;


namespace serial {
    [JsonConverter(typeof(JsonSubtypes), "Parent")]
    [JsonSubtypes.Бляяяяя]
//[JsonPolymorphic(UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor)]
// [JsonDerivedType(typeof(Parent), typeDiscriminator: "Parent")]
// [JsonDerivedType(typeof(Ev), typeDiscriminator: "Ev")]
// [JsonDerivedType(typeof(Ch), typeDiscriminator: "Ch")]
// [JsonDerivedType(typeof(Pr), typeDiscriminator: "Pr")]
// [JsonDerivedType(typeof(Tr), typeDiscriminator: "Tr")]
// [JsonDerivedType(typeof(Vp), typeDiscriminator: "Vp")]
public class Parent {

    public string? code { get; set; }
    public int? timestamp { get; set; }
    
}

}