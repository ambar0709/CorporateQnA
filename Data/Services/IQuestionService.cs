﻿using CorporateQnA.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public interface IQuestionService
    {
        public Task AddQuestion(DbQuestion question);
    }
}
