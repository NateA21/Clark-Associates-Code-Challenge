using ClarkCodingChallenge.Models;
using System;
using System.Collections.Generic;

namespace ClarkCodingChallenge.DataAccess
{
    public class ContactsDataAccess
    {
        //TODO: Place data access code here


        List<UserInfoModel> currentContacts = new List<UserInfoModel>();


        public List<UserInfoModel> Get() {
            return currentContacts;
        }

        public void Add(UserInfoModel user) {
            currentContacts.Add(user);
        }

    }
}
