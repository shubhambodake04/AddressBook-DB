using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB
{
    class AddressBookRepo
    {
        public static string ConnectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=address_book;Integrated Security=True";
        SqlConnection connection = new SqlConnection(ConnectionString);
        public void GetAllDetails()
        {
            try
            {
                AddressBookModel addressBookModel = new AddressBookModel();
                using (this.connection)
                {
                    string query = @"select * from contacts";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            addressBookModel.ID = dr.GetInt32(0);
                            addressBookModel.FirstName = dr.GetString(1);
                            addressBookModel.LastName = dr.GetString(2);
                            addressBookModel.Address = dr.GetString(3);
                            addressBookModel.City = dr.GetString(4);
                            addressBookModel.State = dr.GetString(5);
                            addressBookModel.Zip = dr.GetString(6);
                            addressBookModel.PhoneNumber = dr.GetString(7);
                            addressBookModel.Email = dr.GetString(8);
                            addressBookModel.Type = dr.GetString(9);
                            Console.WriteLine(addressBookModel.ID + " " + addressBookModel.FirstName + "   " + addressBookModel.LastName + "   " + addressBookModel.Address + "   " + addressBookModel.City + "   " + addressBookModel.State + "   " + addressBookModel.Zip + "    " + addressBookModel.PhoneNumber + "   " + addressBookModel.Email + "   " + addressBookModel.Type);
                            Console.WriteLine("\n");

                        }
                    }
                    else
                    {
                        Console.WriteLine("No Data Found");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
