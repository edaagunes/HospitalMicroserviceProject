using Hospital.Review.CQRS.Results;
using Hospital.Review.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Review.CQRS.Handlers
{
	public class GetReviewQueryHandler
	{
		private readonly ReviewContext _context;

		public GetReviewQueryHandler(ReviewContext context)
		{
			_context = context;
		}

		public async Task<List<GetReviewQueryResult>> Handle()
		{
			var values = await _context.UserReviews.ToListAsync();
			return values.Select(x => new GetReviewQueryResult
			{
				Date = x.Date,
				Name = x.Name,
				ReviewDetail = x.ReviewDetail,
				UserId = x.UserId,
				UserReviewId = x.UserReviewId
			}).ToList();
		}
	}
}
