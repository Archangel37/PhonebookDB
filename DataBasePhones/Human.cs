using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBasePhones
{
    [Table("Human")]
    public class Human
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public string surename { get; set; }
        //[Range(6, 99, ErrorMessage = "Incorrect age")]
        public int age { get; set; }
        public Gender gender { get; set; }


        public int? phMailId { get; set; }
        [ForeignKey("phMailId")]
        public PhoneAndMail phoneMail { get; set; }

        //!!!!! хз
        public enum Gender
        {
            Male,
            Female,
            Other
        }

    }
}
