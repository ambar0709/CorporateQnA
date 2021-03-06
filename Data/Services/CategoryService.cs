﻿using CorporateQnA.Data.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Data.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly IDbConnection connection;
        public CategoryService(IConfiguration config)
        {
            connection = new SqlConnection(config.GetConnectionString("CorporateQnADatabase"));
        }

        public async Task AddCategory(DbCategory category)
        {
            var sql = "Insert into Categories(Name,Description)" +
                "values(@Name,@Description)";
            await connection.ExecuteAsync(sql, category);
            return;
        }

        public async Task<List<DbCategory>> GetAllCategories()
        {
            var sql = "select * from Categories Order By QuestionsTagged Desc";
            var categories = await connection.QueryAsync<DbCategory>(sql);
            return categories.AsList();
        }

        public async Task<List<DbCategory>> SearchCategoriesByKeyword(string keyword,int sortBy)
        {
            string orderBy = "";
            if(sortBy == 1)
            {
                orderBy = "QuestionsTagged DESC";
            }
            var sql = "select * from Categories Where Name Like '%"+keyword+"%' Order By "+orderBy;
            var categories = await connection.QueryAsync<DbCategory>(sql);
            return categories.AsList();
        }
    }
}
