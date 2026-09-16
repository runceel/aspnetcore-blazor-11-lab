using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.ViewModels;

public class PersonViewModel
{
    [Display(Name = "名")]
    public string FirstName { get; set; } = "";

    [Display(Name = "姓")]
    public string LastName { get; set; } = "";
}
