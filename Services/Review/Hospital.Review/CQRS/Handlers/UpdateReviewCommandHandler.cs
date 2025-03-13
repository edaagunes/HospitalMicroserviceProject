using Hospital.Review.CQRS.Commands;
using Hospital.Review.DAL.Context;

namespace Hospital.Review.CQRS.Handlers
{
	public class UpdateReviewCommandHandler
	{
		private readonly ReviewContext _context;

		public UpdateReviewCommandHandler(ReviewContext context)
		{
			_context = context;
		}

		public async Task Handle(UpdateReviewCommand command)
		{
			var value=await _context.UserReviews.FindAsync(command.UserReviewId);
			value.ReviewDetail=command.ReviewDetail;
			value.Date=command.Date;
			value.Name=command.Name;
			value.UserId=command.UserId;

			await _context.SaveChangesAsync();
		}
	}
}
