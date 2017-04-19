using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Data.Interfaces;
using BusTicketsSystem.Data.Services;

namespace BusTicketsSystem.ConsoleClient.Core.Commands
{
    public class PublishReviewCommand:Command
    {
        private ReviewService reviewService;

        public PublishReviewCommand(string[] data, IUnitOfWork unitOfWQork) : base(data)
        {
            this.reviewService = new ReviewService(unitOfWQork);
        }

        public override string Execute()
        {
            string result = this.reviewService.PublishReview(this.Data);

            return result;
        }
    }
}
