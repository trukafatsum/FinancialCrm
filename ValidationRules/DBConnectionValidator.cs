using FinancialCrm.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.ValidationRules
{
    public class DBConnectionValidator : AbstractValidator<DBConnection>
    {
        public DBConnectionValidator()
        {
            RuleFor(dc => dc.DataSource)
            .Matches(@"^[a-zA-Z0-9\.\-]+\\?[a-zA-Z0-9]*$")
            .WithMessage("Veritabanı kaynağı geçerli bir sunucu adı veya IP adresi formatında olmalıdır.");


            RuleFor(dc => dc.InitialCatalog)
            .Matches(@"^[a-zA-Z0-9_]+$")
            .WithMessage("Veritabanı adı yalnızca harf, rakam ve alt çizgi içerebilir.");


            RuleFor(dc => dc.UserId)
                .NotNull().NotEmpty().When(dc => !dc.IntegratedSecurity).WithMessage("Kullanıcı adı boş geçilemez!")
                .Length(0, 50).When(dc => !dc.IntegratedSecurity).WithMessage("Kullanıcı adı en fazla 50 karakter olmalıdır.");

            RuleFor(dc => dc.Password)
                .NotNull().NotEmpty().When(dc => !dc.IntegratedSecurity).WithMessage("Şifre boş geçilemez!")
                .Length(0, 50).When(dc => !dc.IntegratedSecurity).WithMessage("Şifre en fazla 50 karakter olmalıdır.");

            RuleFor(dc => dc.IntegratedSecurity)
            .Must(value => value == true || value == false)
            .WithMessage("Integrated Security yalnızca 'true' veya 'false' değerini alabilir.");


            RuleFor(dc => dc.TrustedServerCertificate)
            .Must(value => value == true || value == false)
            .WithMessage("Trusted Server Certificate yalnızca 'true' veya 'false' değerini alabilir.");

        }
    }
}
