using FinancialCrm.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.ValidationRules
{
    public class BankValidator : AbstractValidator<Banks>
    {
        public BankValidator()
        {
            RuleFor(b => b.BankId).NotEmpty().WithMessage("Banka id boş olamaz.");
            RuleFor(b => b.BankBalance).GreaterThan(0).WithMessage("Bakiye 0'dan küçük olamaz.");
        }
    }
}
