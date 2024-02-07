using System.Text.Json;
using System.Text.Json.Serialization;


namespace serial {
[JsonPolymorphic(TypeDiscriminatorPropertyName = "code")]
[JsonDerivedType(typeof(Ev), typeDiscriminator: "ev")]
[JsonDerivedType(typeof(Ch), typeDiscriminator: "ch")]
[JsonDerivedType(typeof(Pr), typeDiscriminator: "pr")]
[JsonDerivedType(typeof(Tr), typeDiscriminator: "tr")]
[JsonDerivedType(typeof(Vp), typeDiscriminator: "vp")]
public class Parent {

    public int? timestamp { get; set; }
    
}

}