using System.ComponentModel.DataAnnotations;

namespace DataBasePhones
{
    public class CellPhone
    {
        [Key]
        public int Id;
        public string manufacturer;
        public string model;
    }
}
