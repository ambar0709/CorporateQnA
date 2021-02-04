using AutoMapper;
using CorporateQnA.Data.Models;
using CorporateQnA.Models;
using Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CorporateQnA.Controllers
{
    [ApiController]
    [Route("api/questions")]
    public class QuestionController:ControllerBase
    {
        private readonly IQuestionService _questionService;
        private readonly IMapper _mapper;

        public QuestionController(IQuestionService questionService,IMapper mapper)
        {
            _questionService = questionService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> AddQuestion(Question question)
        {
            await _questionService.AddQuestion(_mapper.Map<Question, DbQuestion>(question));
            return Ok();
        }
    }
}
