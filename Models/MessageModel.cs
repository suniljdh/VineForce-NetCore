using System.ComponentModel.DataAnnotations;

namespace Crud_Api.Models
{
    public class MessageModel
    {
        [Key]
        public string code { get; set; }
        public string msg { get; set; }
    }
}
