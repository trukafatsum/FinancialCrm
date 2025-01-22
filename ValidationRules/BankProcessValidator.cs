using FinancialCrm.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.ValidationRules
{
    public class BankProcessValidator : AbstractValidator<BankProcesses>
    {
        public BankProcessValidator()
        {
            RuleFor(p => p.BankId).NotEmpty().WithMessage("Banka ID değeri boş olamaz.");
            RuleFor(p => p.Amount).GreaterThan(0).WithMessage("Tutar 0'dan büyük olmak zorundadır.");
            //..
        }
    }
}
