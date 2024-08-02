using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Primitives;

namespace Yt_Dot6Identity.Models
{
    [Table("Poter")]
    public class Poter
    {
        [Key]
        public int Id {get; set;}
        public int EmpId { get; set; }    
        public string PoterFname { get; set; }  
        public string PoterLname { get; set; }
    }
}