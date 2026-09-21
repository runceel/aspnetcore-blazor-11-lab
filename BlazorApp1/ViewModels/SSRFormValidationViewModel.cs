using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.ViewModels;

public class SSRFormValidationViewModel
{
    [Display(Name = "名前")]
    [Required(ErrorMessage = "名前は必須です。")]
    public string Name { get; set; } = "";

    [Display(Name = "説明")]
    [Required(ErrorMessage = "説明は必須です。")]
    [MinLength(10, ErrorMessage = "説明は10文字以上で入力してください。")]
    public string Description { get; set; } = "";
}
