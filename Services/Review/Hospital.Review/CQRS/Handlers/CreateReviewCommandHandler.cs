using Hospital.Review.CQRS.Commands;
using Hospital.Review.DAL.Context;
using Hospital.Review.DAL.Entities;

namespace Hospital.Review.CQRS.Handlers
{
	public class CreateReviewCommandHandler
	{
		private readonly ReviewContext _context;

		public CreateReviewCommandHandler(ReviewContext context)
		{
			_context = context;
		}

		public async Task Handle(CreateReviewCommand command)
		{
			_context.UserReviews.Add(new UserReview
			{
				Date = command.Date,
				Name = command.Name,
				ReviewDetail = command.ReviewDetail,
				UserId = command.UserId,
			});
			await _context.SaveChangesAsync();
		}
	}
}
