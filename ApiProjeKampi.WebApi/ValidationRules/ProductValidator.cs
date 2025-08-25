using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçmeyin.");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapın.");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapın.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("ürün fiyatı boş geçilmez.").GreaterThan(0).WithMessage("ürün fiyatı negatif olamaz.").LessThan(1000).WithMessage("ürün fiyatı çok yüksek, bu kadar olamaz.");
            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("ürün açıklaması boş geçilemez.");

        }
    }
}
