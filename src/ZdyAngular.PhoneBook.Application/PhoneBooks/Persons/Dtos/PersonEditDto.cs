
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using ZdyAngular.PhoneBook.PhoneBooks.Persons;

namespace  ZdyAngular.PhoneBook.PhoneBooks.Persons.Dtos
{
    public class PersonEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; set; }         


        
		/// <summary>
		/// Name
		/// </summary>
[MaxLength(PhoneBookConsts.MaxNameLength)]
		[Required(ErrorMessage="Name不能为空")]
		public string Name { get; set; }



		/// <summary>
		/// EmailAddress
		/// </summary>
[MaxLength(PhoneBookConsts.MaxEmailAddressLength)]
		[Required(ErrorMessage="EmailAddress不能为空")]
		public string EmailAddress { get; set; }



		/// <summary>
		/// Address
		/// </summary>
[MaxLength(PhoneBookConsts.MaxAddressLength)]
		public string Address { get; set; }




    }
}