using FinancialCrm.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.ValidationRules
{
    public class SpendingValidator : AbstractValidator<Spendings>
    {
        public SpendingValidator()
        {
            RuleFor(s => s.SpendingTitle)
            .NotEmpty().WithMessage("Harcama başlığı boş olamaz.")
            .Length(3, 100).WithMessage("Harcama başlığı 3 ile 100 karakter arasında olmalıdır.");

            RuleFor(s => s.SpendingAmount)
                .GreaterThan(0).WithMessage("Harcama tutarı sıfırdan büyük olmalıdır.");

            RuleFor(s => s.SpendingDate)
                .NotNull().WithMessage("Harcama tarihi boş olamaz.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Harcama tarihi gelecekte olamaz.");

            RuleFor(s => s.CategoryId)
                .GreaterThan(0).WithMessage("Kategori seçilmelidir.");
        }
    }
}
