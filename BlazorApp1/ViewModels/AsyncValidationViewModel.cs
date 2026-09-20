using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.ViewModels;

public class AsyncValidationViewModel
{
    [Required(ErrorMessage = "Name is required.")] // 同期的
    [UniqueName] // 非同期的
    [Display(Name = "★Name★")]
    public string Name { get; set; } = "";
}

public class UniqueNameAttribute : AsyncValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext) =>
        throw new NotSupportedException();

    protected override async Task<ValidationResult?> IsValidAsync(object? value, ValidationContext validationContext, CancellationToken cancellationToken)
    {
        await Task.Delay(3000, cancellationToken); // 3秒待機して、非同期処理をシミュレートする

        // 本来なら DB とかにアクセスしてユニークかどうかチェックするけど取り合えず固定値で
        if (value is string name && name == "Kazuki")
        {
            return new ValidationResult("Name must be unique.");
        }

        return ValidationResult.Success;
    }
}