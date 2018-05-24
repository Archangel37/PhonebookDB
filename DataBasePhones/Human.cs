using System.ComponentModel.DataAnnotations;

namespace DataBasePhones
{
    public class Human
    {
        [Key]
        public int Id;
        [Required]
        public string name;
        public string surename;
        [Range(6, 99, ErrorMessage = "Incorrect age")]
        public int age;
        public Gender gender;
        public PhoneAndMail phoneMail;

        //!!!!! хз
        public enum Gender
        {
            Male,
            Female,
            Other
        }

    }
}
