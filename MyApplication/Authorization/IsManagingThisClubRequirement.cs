using Microsoft.AspNetCore.Authorization;

namespace MyApplication.Authorization
{
    public class IsManagingThisClubRequirement : IAuthorizationRequirement
    {
    }
}
