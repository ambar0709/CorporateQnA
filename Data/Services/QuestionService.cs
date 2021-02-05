using CorporateQnA.Data.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class QuestionService:IQuestionService
    {
        private readonly IDbConnection connection;
        public QuestionService(IConfiguration config)
        {
            connection = new SqlConnection(config.GetConnectionString("CorporateQnADatabase"));
        }

        public async Task AddQuestion(DbQuestion question)
        {
            question.CreatedOn = DateTime.Now;
            var sql = "insert into Questions(Title,Description,CategoryId,UserId,CreatedOn)" +
                "values(@Title,@Description,@CategoryId,@UserId,@CreatedOn)";
            await connection.ExecuteAsync(sql,question);
            sql = "Update Categories " +
                "Set QuestionsTagged=QuestionsTagged+1 " +
                "Where Id=@Id";
            await connection.ExecuteAsync(sql,new { Id=question.CategoryId});
            return;
        }
    }
}
