using EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.CreateQuiz;
using EmemIsaac.QuizManager.Application.Features.Quizzes.Queries.GetUsersQuizzes;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmemIsaac.QuizManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IMediator _mediator;

        public QuizController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name ="GetAllQuizzes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<QuizVM>>> GetAllQuizzes()
        {
            var quizzes = await _mediator.Send(new GetQuizzessQuery() { CreatorUserId = User.Identity.Name });
            return Ok(quizzes);
        }

        [HttpPost(Name = "AddQuiz")]
        public async Task<ActionResult<CreateQuizCommandResponse>> Create([FromBody] CreateQuizCommand createQuizCommand)
        {
            var response = await _mediator.Send(createQuizCommand);
            return Ok(response);
        }
    }
}
