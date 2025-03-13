using Hospital.Review.CQRS.Commands;
using Hospital.Review.DAL.Context;

namespace Hospital.Review.CQRS.Handlers
{
	public class RemoveReviewCommandHandler
	{
		private readonly ReviewContext _context;

		public RemoveReviewCommandHandler(ReviewContext context)
		{
			_context = context;
		}

		public async Task Handle(RemoveReviewCommand command)
		{
			var value = await _context.UserReviews.FindAsync(command.Id);
			_context.UserReviews.Remove(value);
			await _context.SaveChangesAsync();
		}
	}
}
