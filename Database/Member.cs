using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Member
    {
        public Member()
        {
            Contact = new HashSet<Contact>();
            DebitSystem = new HashSet<DebitSystem>();
            Diagnosis = new HashSet<Diagnosis>();
            Medication = new HashSet<Medication>();
            Picture = new HashSet<Picture>();
            SignIn = new HashSet<SignIn>();
        }

        public int MemberId { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public sbyte? Sex { get; set; }
        public string CountryOfOrigin { get; set; }
        public sbyte? Aboriginal { get; set; }
        public string StreetAddress { get; set; }
        public string PostCode { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string TelephoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? DateJoined { get; set; }
        public sbyte? ReceiveNewsletter { get; set; }
        public sbyte? ReceiveByMail { get; set; }
        public sbyte? BirthdayCard { get; set; }
        public sbyte? Working { get; set; }
        public sbyte? Volunteering { get; set; }
        public sbyte? Studying { get; set; }
        public sbyte? Archived { get; set; }
        public DateTime? DateAltered { get; set; }
        public sbyte? Agency { get; set; }

        public ICollection<Contact> Contact { get; set; }
        public ICollection<DebitSystem> DebitSystem { get; set; }
        public ICollection<Diagnosis> Diagnosis { get; set; }
        public ICollection<Medication> Medication { get; set; }
        public ICollection<Picture> Picture { get; set; }
        public ICollection<SignIn> SignIn { get; set; }
    }
}
