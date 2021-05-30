using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookRepo repo = new AddressBookRepo();
            AddressBookModel contact = new AddressBookModel();

            /*contact.FirstName = "Sham";
            contact.LastName = "Sundar";
            contact.Address = "02-Delhi";
            contact.City = "Delhi";
            contact.State = "Delhi";
            contact.Zip = "589612";
            contact.PhoneNumber = "8877559966";
            contact.Email = "sham@gmail.com";
            contact.Type = "Friend";
            if (repo.AddPersonDetails(contact))
                Console.WriteLine("Records added successfully");*/

            //repo.GetAllDetails();
            //repo.UpdateDetails();
            repo.Remove();
            Console.ReadKey();
        }
    }
}
