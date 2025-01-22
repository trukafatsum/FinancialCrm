using FinancialCrm.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Categories>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName)
            .NotEmpty().WithMessage("Kategori adı boş olamaz!")
            .Length(3, 50).WithMessage("Kategori adı en az 3, en fazla 50 karakter olmalıdır.");
        }
    }
}
