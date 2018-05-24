using System.ComponentModel.DataAnnotations;

namespace DataBasePhones
{
    public class PhoneAndMail
    {
        [Key]
        public int Id;
        [RegularExpression(@"(/^(\+7|8){1}(\s|\-|\()?\d{3}(\s|\-|\))?\d{3}(\s|\-)?\d{2}(\s|\-)?\d{2}$/)", ErrorMessage = "Incorrect phone number")]
        public string phoneNumber;
        public CellPhone cellPhone;
        [EmailAddress]
        public string email;
    }
}
