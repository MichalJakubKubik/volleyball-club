
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using MyApplication.Entities;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace MyApplication.Authorization
{
    public class IsManagingThisClubRequirementHandler : AuthorizationHandler<IsManagingThisClubRequirement, Staff>
    {
        private readonly ClubDbContext _dbContext;
        public IsManagingThisClubRequirementHandler(ClubDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsManagingThisClubRequirement requirement, Staff staff)
        {

            var role = context.User.FindFirst(c => c.Type == ClaimTypes.Role).Value;

            if (role == "Admin")
            {
                context.Succeed(requirement);
            }
            else if(role == "Manager")
            {
                var isManagingClub = int.Parse(context.User.FindFirst(c => c.Type == "ManagingClub").Value);
                var playerClubId = staff.ClubId;

                if (staff.ClubId == 0)
                    playerClubId = staff.Club.Id;

                if (playerClubId == isManagingClub)
                    context.Succeed(requirement);
            }
            else
            {

            }

            return Task.CompletedTask;
        }
    }
}
