using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBasePhones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_index.Text = indexDB.ToString();
        }

        PhonebookDB db = new PhonebookDB();
        int indexDB = 0;

        private void DoDefault_btn_Click(object sender, EventArgs e)
        {
            DBDataSetter.AddDefaults(db);
            db.SaveChanges();
            MessageBox.Show(db.People.Count().ToString() + "\n" + db.PhonesAndMails.Count().ToString() + "\n" + db.CellPhones.Count().ToString());
        }

        private void ShowRecord_btn_Click(object sender, EventArgs e)
        {
            if (db.People.Count() > 0)
            {
               var ListDB = db.GetPeople();
                if (ListDB.Count>0)
                ListToControls(ListDB, 0);
            }
        }


        private void ListToControls(List<Human> ListDB, int index)
        {
            Human_Name_txt.Text = ListDB[index].name;
            Human_Surename_txt.Text = ListDB[index].surename;
            Human_Age_txt.Text = ListDB[index].age.ToString(); //!!!!!!!!
            comboBox_Gender.DisplayMember = ListDB[index].gender.ToString();

            //тут начинается беда со связями
            PhoneNumber_txt.Text = ListDB[index].phoneMail.phoneNumber;
            Manufacturer_Phone_txt.Text = ListDB[index].phoneMail.cellPhone.manufacturer;
            Model_Phone_txt.Text = ListDB[index].phoneMail.cellPhone.model;
            Email_txt.Text = ListDB[index].phoneMail.email;
        }

        private Human ControlsToList()
        {
            return new Human
            { name = Human_Name_txt.Text, surename = Human_Surename_txt.Text, age = int.Parse(Human_Age_txt.Text), gender = 
            comboBox_Gender.DisplayMember == "Male"? Human.Gender.Male :
            comboBox_Gender.DisplayMember == "Female" ? Human.Gender.Female : Human.Gender.Other,
                phoneMail = new PhoneAndMail { email = Email_txt.Text, phoneNumber = PhoneNumber_txt.Text,
                    cellPhone = new CellPhone { manufacturer = Manufacturer_Phone_txt.Text, model = Model_Phone_txt.Text }}};
        }

        private void AddRecord_btn_Click(object sender, EventArgs e)
        {
            db.People.Add(ControlsToList());
        }

        private void DropDB_btn_Click(object sender, EventArgs e)
        {
           
            db.CellPhones.RemoveRange(db.CellPhones.ToList());
            db.PhonesAndMails.RemoveRange(db.PhonesAndMails.ToList());
            db.People.RemoveRange(db.People.ToList());
            db.SaveChanges();
            MessageBox.Show("OK!");
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (db.People.Count()-1 > indexDB) indexDB++;
            label_index.Text = indexDB.ToString();
            ListToControls(db.GetPeople(), indexDB);
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            if (indexDB > 0) indexDB--;
            label_index.Text = indexDB.ToString();
            ListToControls(db.GetPeople(), indexDB);
        }
    }
}
