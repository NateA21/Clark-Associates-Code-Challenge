using ClarkCodingChallenge.DataAccess;
using ClarkCodingChallenge.Models;
using System.Collections.Generic;

namespace ClarkCodingChallenge.BusinessLogic
{
    public class ContactsService
    {
        //TODO: Place business logic for contact here
        private ContactsDataAccess ContactsDataAccess;
        public ContactsService(ContactsDataAccess contactsDataAccess) {

            ContactsDataAccess = contactsDataAccess;
        }

        public List<UserInfoModel> Get() {
            return ContactsDataAccess.Get();
        }

        public void Add(UserInfoModel user) {
            ContactsDataAccess.Add(user);
        }

        public List<UserInfoModel> Get(string LastName) {
             List<UserInfoModel> FilteredContacts = null;
             List<UserInfoModel> Contacts = ContactsDataAccess.Get();
             Contacts.ForEach(contact => {
                 if (contact.LastName.Contains(LastName)) {
                     FilteredContacts.Add(contact);
                 }
             });
             return FilteredContacts;
        }

    }
}
