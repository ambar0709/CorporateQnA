using AutoMapper;
using CorporateQnA.Data.Models;
using CorporateQnA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporateQnA.Profiles
{
    public class CorporateQnAProfile:Profile
    {
        public CorporateQnAProfile()
        {
            CreateMap<User,AuthUser>();
            CreateMap<Category,DbCategory>();
            CreateMap<DbCategory,Category>();
            CreateMap<Question,DbQuestion>();
        }
    }
}
