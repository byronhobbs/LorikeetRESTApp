using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using LorikeetRESTApp.Classes;
using LorikeetRESTApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace LorikeetRESTApp.Controllers
{
    public class ProtectedController : Controller
    {
        [HttpGet]
        [Authorize]
        [Route("/api/member")]
        public IActionResult GetProtectedData()
        {
			Contract.Ensures(Contract.Result<IActionResult>() != null);
			using (var context = new Database.LorikeetAppContext())
			{
				List<Models.Member> membersToREST = new List<Models.Member>();
				var members = context.Member.ToList();
				foreach (var item in members)
				{
					if (item.Agency == 0 && item.Archived == 0)
					{
						var Member = new Models.Member();
						Member.MemberId = item.MemberId;
						Member.Surname = item.Surname;
						Member.FirstName = item.FirstName;
						Member.DateOfBirth = item.DateOfBirth;
						Member.Sex = item.Sex;
						Member.Aboriginal = item.Aboriginal;
						Member.StreetAddress = item.StreetAddress;
						Member.PostCode = item.PostCode;
						Member.Suburb = item.Suburb;
						Member.State = item.State;
						Member.Country = item.Country;
						Member.TelephoneNumber = item.TelephoneNumber;
						Member.MobileNumber = item.MobileNumber;
						Member.EmailAddress = item.EmailAddress;
						Member.DateAltered = item.DateAltered;
                        Member.PictureGUID = item.PictureGuid;
						membersToREST.Add(Member);
					}
				}
				return Ok(membersToREST);
			}
        }

        [HttpGet]
        [Authorize]
        [Route("/api/contacts")]
        public IActionResult GetProtectedDataForAdmin()
        {
            Contract.Ensures(Contract.Result<IActionResult>() != null);
            using (var context = new Database.LorikeetAppContext())
            {
                List<Models.Contact> contactsToRest = new List<Models.Contact>();
                var contacts = context.Contact.ToList();
                foreach (var item in contacts)
                {
                    var Contact = new Models.Contact();
                    Contact.ContactId = item.ContactId;
                    Contact.MemberId = item.MemberId;
                    Contact.ContactType = item.ContactType;
                    Contact.ContactName = item.ContactName;
                    Contact.ContactAddress = item.ContactAddress;
                    Contact.ContactPhone = item.ContactPhone;

                    contactsToRest.Add(Contact);
                }
                return Ok(contactsToRest);
            }
        }        
    }
}