using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAddressBookProblem
{
    interface IContacts
    {
        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber);
        public void ViewContact(string name);
        public void EditContact(string name);
        public void DeleteContact(string name);
        public void AddAddressBook(string bookName);
    }
}
