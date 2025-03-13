using Hospital.Review.CQRS.Queries;
using Hospital.Review.CQRS.Results;
using Hospital.Review.DAL.Context;

namespace Hospital.Review.CQRS.Handlers
{
	public class GetReviewByIdQueryHandler
	{
		private readonly ReviewContext _context;

		public GetReviewByIdQueryHandler(ReviewContext context)
		{
			_context = context;
		}

		public async Task<GetReviewByIdQueryResult> Handle(GetReviewByIdQuery getReviewByIdQuery)
		{
			var value=await _context.UserReviews.FindAsync(getReviewByIdQuery.Id);
			return new GetReviewByIdQueryResult
			{
				Date = value.Date,
				Name = value.Name,
				ReviewDetail = value.ReviewDetail,
				UserId = value.UserId,
				UserReviewId = value.UserReviewId
			};
		}
	}
}
