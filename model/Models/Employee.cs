using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Employee")]
public class Employee {

    [Key]
    public int id { get; set; }
    public string name { get; set; }
}