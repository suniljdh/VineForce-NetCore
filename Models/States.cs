using System.ComponentModel.DataAnnotations;

namespace Crud_Api.Models
{
    public class States
    {
        public Int64 rno { get; set; }

        public string aed { get; set; }

        [Key]
        public int stateid { get; set; }
        public string statename { get; set; }
        public int countryid { get; set; }

        public string countryname { get; set; }

    }
}
