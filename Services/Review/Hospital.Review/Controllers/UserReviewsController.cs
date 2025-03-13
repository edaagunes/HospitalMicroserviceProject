using Hospital.Review.CQRS.Commands;
using Hospital.Review.CQRS.Handlers;
using Hospital.Review.CQRS.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Review.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class UserReviewsController : ControllerBase
	{
		private readonly CreateReviewCommandHandler _createUserReviewCommandHandler;
		private readonly UpdateReviewCommandHandler _updateUserReviewCommandHandler;
		private readonly RemoveReviewCommandHandler _removeUserReviewCommandHandler;
		private readonly GetReviewByIdQueryHandler _getReviewByIdQueryHandler;
		private readonly GetReviewQueryHandler _getReviewQueryHandler;

		public UserReviewsController(CreateReviewCommandHandler createUserReviewCommandHandler, UpdateReviewCommandHandler updateUserReviewCommandHandler, RemoveReviewCommandHandler removeUserReviewCommandHandler, GetReviewByIdQueryHandler getReviewByIdQueryHandler, GetReviewQueryHandler getReviewQueryHandler)
		{
			_createUserReviewCommandHandler = createUserReviewCommandHandler;
			_updateUserReviewCommandHandler = updateUserReviewCommandHandler;
			_removeUserReviewCommandHandler = removeUserReviewCommandHandler;
			_getReviewByIdQueryHandler = getReviewByIdQueryHandler;
			_getReviewQueryHandler = getReviewQueryHandler;
		}
		[HttpGet]
		public async Task<IActionResult> ReviewList()
		{
			var value = await _getReviewQueryHandler.Handle();
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateReview(CreateReviewCommand command)
		{
			await _createUserReviewCommandHandler.Handle(command);
			return Ok("Ekleme Başarılı");
		}
		[HttpDelete]
		public async Task<IActionResult> RemoveUserReview(int id)
		{
			await _removeUserReviewCommandHandler.Handle(new RemoveReviewCommand(id));
			return Ok();
		}
		[HttpPut]
		public async Task<IActionResult> UpdateReview(UpdateReviewCommand command)
		{
			await _updateUserReviewCommandHandler.Handle(command);
			return Ok("Güncelleme Başarılı");
		}
		[HttpGet("id")]
		public async Task<IActionResult> GetUserReview(int id)
		{
			var values = await _getReviewByIdQueryHandler.Handle(new GetReviewByIdQuery(id));
			return Ok(values);
		}
	}
}
