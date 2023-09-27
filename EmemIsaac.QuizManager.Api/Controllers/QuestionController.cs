using EmemIsaac.QuizManager.Application.Features.Questions.Commands.CreateQuestion;
using EmemIsaac.QuizManager.Application.Features.Questions.Commands.UpdateQuestion;
using EmemIsaac.QuizManager.Application.Features.Questions.Queries.GetQuestions;
using EmemIsaac.QuizManager.Application.Features.Questions.Queries.GetQuizQuestions;
using EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.CreateQuiz;
using EmemIsaac.QuizManager.Application.Features.Quizzes.Queries.GetUsersQuizzes;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmemIsaac.QuizManager.Api.Controllers
{
    [Route("api/quizes/{quizId}/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public QuestionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllQuestions")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<QuizVM>>> GetAllQuestions(Guid quizId)
        {
            var questions = await _mediator.Send(new GetQuestionsQuery() { QuizId = quizId });
            return Ok(questions);
        }

        [HttpPost(Name = "AddQuestion")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CreateQuestionCommandResponse>> Create(Guid quizId, CreateQuestionCommand createQuestionCommand)
        {
            if (quizId != createQuestionCommand.QuizId)
            {
                return BadRequest("Quiz id mismatch");
            }
            var response = await _mediator.Send(createQuestionCommand);
            return Created("GetQuestion", response);
        }

        [HttpPut(Name = "UpdateQuestion")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<UpdateQuestionCommandResponse>> Update(Guid quizId, UpdateQuestionCommand updateQuestionCommand)
        {
            if (quizId != updateQuestionCommand.QuizId)
            {
                return BadRequest("Quiz id mismatch");
            }
            var response = await _mediator.Send(updateQuestionCommand);
            return Ok(response);
        }

        [HttpGet(Name = "GetQuestion")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetQuestionQueryResponse>> Get(Guid quizId, GetQuestionQuery getQuestionQuery)
        {
            if (quizId != getQuestionQuery.QuizId)
            {
                return BadRequest("Quiz id mismatch");
            }
            var response = await _mediator.Send(getQuestionQuery);
            return Ok(response);
        }
    }
}
