using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBasePhones
{
    [Table("CellPhone")]
    public class CellPhone
    {
        [Key]
        public int Id { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
    }
}
