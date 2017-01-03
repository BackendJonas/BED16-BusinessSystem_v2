using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BED16_BusinessSystem_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store<Product> MyStore = new Store<Product>();
            CustomerDatabase<Customer> MyCustomerDB = new CustomerDatabase<Customer>();
            Menu.ShowMainMenu(MyStore, MyCustomerDB);
            
        }

        static int checkInt(int userInput)
        {


            return userInput;
        }
    }
}
