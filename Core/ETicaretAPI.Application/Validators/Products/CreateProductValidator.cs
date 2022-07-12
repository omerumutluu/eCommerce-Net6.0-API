using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                    .WithMessage("Lütfen ürün adını boş geçmeyiniz.")
                .NotNull()
                    .WithMessage("Lütfen ürün adını boş geçmeyiniz.")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Lütfen ürün adını 5 ile 150 karekter arasında giriniz.");

            RuleFor(p => p.Stock)
                .NotEmpty()
                    .WithMessage("Lütfen stok bilgisini boş geçmeyiniz.")
                .NotNull()
                    .WithMessage("lütfen stok bilgisini boş geçmeyiniz")
                .Must(s => s >= 0)
                    .WithMessage("Stok bilgisi negatif olamaz!");

            RuleFor(p => p.Price)
                .NotEmpty()
                    .WithMessage("Lütfen ürün fiyatını boş geçmeyiniz.")
                .NotNull()
                    .WithMessage("Lütfen ürün fiyatını giriniz.")
                .Must(s => s >= 0)
                    .WithMessage("Fiyat bilgisi negatif olamaz!");
        }
    }
}
