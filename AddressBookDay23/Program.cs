using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address BOOK Program");
            AddressBook ab = new AddressBook("Prajakta","hjdhjd","abs","Mumbai","Maharashtra", "pra23@gmail.com", 400023, 9632587412);
            ab.DisplayContacts();
        }
    }
}