using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook2
{
    public struct PhoneBookEntry
    {
        public PhoneBookEntry(string Name, string PhoneNumber, ContactType EntryType)
        {
            this.EntryType = EntryType;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;

        }
        public string Name;
        public string PhoneNumber;
        public enum ContactType 
        {
            Personal, Business, Etc
        }
        public ContactType EntryType;

    }
}
