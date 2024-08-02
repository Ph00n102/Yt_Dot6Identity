using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Primitives;

namespace Yt_Dot6Identity.Models;

[Table("NurseRequest")]
public class NurseRequest
{
    
    [Key]
    public int  JobId   { get; set; }
    public DateTime ReqDate { get; set; }   
    public DateTime ReqTime { get; set; }
    public DateTime EndDate { get; set; }   
    public DateTime EndTime { get; set; }   
    public int UserId { get; set; } 
    public string? Department { get; set; }
    public string? StartPoint { get; set; }
    public string? EndPoint { get; set; }
    public string? MaterialType { get; set; }   
    public string? UrentType { get; set; }
    public string? PatientType { get; set; }
    public string? PoterFname { get; set; }
    public string? JobStatusName { get; set; }
    public string? Remark { get; set; }
    public int QN { get; set; }
    public string? QNName { get; set; }  
    public string? QNAge { get; set; }   
    public string? QNSex { get; set; }   

}
