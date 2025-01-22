using FinancialCrm.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.ValidationRules
{
    public class UserValidator : AbstractValidator<Users>
    {
        public UserValidator()
        {
            // FirstName doğrulaması
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Ad boş olamaz.")
                .MinimumLength(2).WithMessage("Ad en az 2 karakter olmalı.");

            // LastName doğrulaması
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Soyad boş olamaz.")
                .MinimumLength(2).WithMessage("Soyad en az 2 karakter olmalı.");

            // Username doğrulaması
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Kullanıcı adı boş olamaz.")
                .MinimumLength(5).WithMessage("Kullanıcı adı en az 5 karakter olmalı.");

            // Password doğrulaması
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Şifre boş olamaz.");
                //.MinimumLength(5).WithMessage("Şifre en az 8 karakter olmalı.")
                //.Matches(@"[A-Z]").WithMessage("Şifre en az bir büyük harf içermelidir.")
                //.Matches(@"[a-z]").WithMessage("Şifre en az bir küçük harf içermelidir.")
                //.Matches(@"[0-9]").WithMessage("Şifre en az bir rakam içermelidir.");

        }
    }
}
