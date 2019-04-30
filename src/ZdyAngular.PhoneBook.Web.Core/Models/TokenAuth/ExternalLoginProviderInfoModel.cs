﻿using Abp.AutoMapper;
using ZdyAngular.PhoneBook.Authentication.External;

namespace ZdyAngular.PhoneBook.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
