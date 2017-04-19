using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Data.Interfaces;
using BusTicketsSystem.Data.Services;

namespace BusTicketsSystem.ConsoleClient.Core.Commands
{
    public class PrintReviewsCommand : Command
    {
        private ReviewService reviewsService;

        public PrintReviewsCommand(string[] data, IUnitOfWork unitOfWork) : base(data)
        {
            this.reviewsService= new ReviewService(unitOfWork);
        }

        public override string Execute()
        {
            string result = this.reviewsService.ReturnReviews(int.Parse(this.Data[1]));

            return result;
        }
    }
}
