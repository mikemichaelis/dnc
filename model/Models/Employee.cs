using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Employee")]
public class Employee {

    [Key]
    public int id { get; set; }
    public string firstName { get; set; }
    public string middleName { get; set; }
    public string lastName { get; set; }
    public string phone { get; set; }
    public string address1 { get; set; }
    public string address2 { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zip { get; set; }
    public string country { get; set; }
    public DateTime hireDate { get; set; }    
}