﻿namespace DataBasePhones
{
    public static class DBDataSetter
    {
        public static void AddDefaults(PhonebookDB dB)
        {
            dB.People.Add(new Human { name = "Paul", surename = "Oakenfold", age = 54, gender = Human.Gender.Other, phoneMail = new PhoneAndMail { email = "pauloakenfold@gmail.com", phoneNumber = "+79999999999", cellPhone = new CellPhone { manufacturer = "iPhone", model = "iPhone X" } } });
            dB.People.Add(new Human { name = "Matthias", surename = "Paul", age = 46, gender = Human.Gender.Male, phoneMail = new PhoneAndMail { email = "paul_van_dyk@gmail.com", phoneNumber = "+7(699)999-99-99", cellPhone = new CellPhone { manufacturer = "iPhone", model = "iPhone 8" } } });
            dB.People.Add(new Human { name = "Kirill", surename = "Tolmackij", age = 34, gender = Human.Gender.Male, phoneMail = new PhoneAndMail { email = "decl_yo@gmail.com", phoneNumber = "+7(699)222-99-99", cellPhone = new CellPhone { manufacturer = "Sony Ericsson", model = "K750i" } } });
        }
    }
}
