using System.ComponentModel.DataAnnotations;

namespace Crud_Api.Models
{
    public class Country
    {
        public Int64 rno { get; set; }
        public string aed { get; set; }
        [Key]
        public int countryid { get; set; }
        public string countryname { get; set; }
    }
}
