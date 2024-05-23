using System.ComponentModel.DataAnnotations;
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

    [Required]
    [Range(1691408464,1691408470)]
    public int? timestamp { get; set; }
    
}

}