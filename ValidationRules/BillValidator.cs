using FinancialCrm.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.ValidationRules
{
    public class BillValidator : AbstractValidator<Bills>
    {
        public BillValidator()
        {
            RuleFor(b => b.BillTitle)
            .NotEmpty().WithMessage("Fatura başlığı boş olamaz!")
            .MaximumLength(100).WithMessage("Fatura başlığı en fazla 100 karakter olmalıdır!");

            RuleFor(b => b.BillPeriod)
            .NotEmpty().WithMessage("Fatura dönemi boş olamaz!")
            .Must(IsValidTurkishMonthYearFormat)
            .WithMessage("Fatura dönemi geçerli bir formatta olmalıdır! (Örnek: Ocak 2025)");

            RuleFor(b => b.BillAmount)
                .GreaterThan(0).WithMessage("Fatura tutarı sıfırdan büyük olmalıdır!");
        }
        private bool IsValidTurkishMonthYearFormat(string period)
        {
            if (string.IsNullOrWhiteSpace(period)) return false;

            // Ay isimleri ve yıl kontrolü
            var turkishMonths = new[]
            {
            "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
            "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"
        };

            var parts = period.Split(' ');
            if (parts.Length != 2) return false;

            string month = parts[0];
            string year = parts[1];

            return turkishMonths.Contains(month) && int.TryParse(year, out int yearValue) && yearValue > 1900 && yearValue < 2100;
        }
    }
}
