using Hospital.Review.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Review.DAL.Context
{
	public class ReviewContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=localhost,1440;initial catalog=ReviewDb;User=sa;Password=123456aA*;trust server certificate=true");
		}

		public DbSet<UserReview> UserReviews { get; set; }
	}
}
