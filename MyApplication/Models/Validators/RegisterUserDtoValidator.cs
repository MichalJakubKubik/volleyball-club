using FluentValidation;
using MyApplication.Entities;

namespace MyApplication.Models.Validators
{
    public class RegisterUserDtoValidator : AbstractValidator<RegisterUserDto>
    {
        public RegisterUserDtoValidator(ClubDbContext dbContext)
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                .Custom((value, context) =>
                {
                    var emailInUse = dbContext.Users.Any(x => x.Email == value);
                    if (emailInUse)
                    {
                        context.AddFailure("Email", "That email is in use already");
                    }
                }); 

            RuleFor(x => x.Password)
                .MinimumLength(6)
                .Equal(x => x.ConfirmPassword);
        }
    }
}
