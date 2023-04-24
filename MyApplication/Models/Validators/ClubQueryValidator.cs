using FluentValidation;
using MyApplication.Entities;

namespace MyApplication.Models.Validators
{
    public class ClubQueryValidator : AbstractValidator<ClubQuery>
    {
        private int[] allowedPageSizes = new[] { 5, 10, 15 };
        private string[] allowedSortByColumnNames = { nameof(Club.ShortName), nameof(Club.FullName)};

        public ClubQueryValidator()
        {
            RuleFor(r => r.PageNumber).GreaterThanOrEqualTo(1);
            RuleFor(r => r.PageSize).Custom((value, context) =>
            {
                if(!allowedPageSizes.Contains(value))
                {
                    context.AddFailure("PageSize", $"PageSize ust in [{string.Join(",", allowedPageSizes)}]");
                }
            });

            RuleFor(r => r.SortBy)
                .Must(value => string.IsNullOrEmpty(value) || allowedSortByColumnNames.Contains(value))
                .WithMessage($"Sort by is optional or must be in [{string.Join(",", allowedSortByColumnNames)}]");
        }
    }
}
