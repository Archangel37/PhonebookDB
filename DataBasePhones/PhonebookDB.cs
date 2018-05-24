using System.Data.Entity;

namespace DataBasePhones
{
    public class PhonebookDB: DbContext
    {
        public PhonebookDB() : base("PhonebookDB")
        {

        }

        static PhonebookDB()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PhonebookDB>());
        }

        public DbSet<Human> People { get; set; }

        public DbSet<PhoneAndMail> PhonesAndMails { get; set; }

        public DbSet<CellPhone> CellPhones { get; set; }
    }
}
