using API_ProjeKampi.WebAPI.Entities;
using FluentValidation;

namespace API_ProjeKampi.WebAPI.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator() 
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş bırakılamaz.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Ürün adı uzunluğunu kontrol ediniz.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Ürün adı 50 karakterden uzun olamaz.");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş bırakılamaz.");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Ürün fiyatını kontrol ediniz.");
            RuleFor(x => x.Price).LessThan(1000).WithMessage("Ürün fiyatı için maksimum 1000 yazılabilir.");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Ürün açıklaması boş bırakılamaz.");
        
        }
    }
}
