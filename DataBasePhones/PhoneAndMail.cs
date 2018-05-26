using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBasePhones
{
    [Table("PhoneAndMail")]
    public class PhoneAndMail
    {
        [Key]
        public int Id { get; set; }
        //[RegularExpression(@"(/^(\+7|8){1}(\s|\-|\()?\d{3}(\s|\-|\))?\d{3}(\s|\-)?\d{2}(\s|\-)?\d{2}$/)", ErrorMessage = "Incorrect phone number")]
        public string phoneNumber { get; set; }

        public int? cellPhoneId { get; set; }
        [ForeignKey("cellPhoneId")]
        public CellPhone cellPhone { get; set; }
        //[EmailAddress]
        public string email { get; set; }
    }
}
