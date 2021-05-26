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

            repo.GetAllDetails();
            Console.ReadKey();
        }
    }
}
