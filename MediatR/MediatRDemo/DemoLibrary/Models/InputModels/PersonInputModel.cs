using System.ComponentModel.DataAnnotations;

using static DemoLibrary.Models.ModelsConstant;

namespace DemoLibrary.Models.InputModels
{
    public class PersonInputModel
    {
        [Required]
        [StringLength(ModelsConstant.PersonNameMinLength,
            MinimumLength = ModelsConstant.PersonNameMaxLength,
            ErrorMessage = ModelsConstant.PersonFirstName)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(ModelsConstant.PersonNameMinLength,
            MinimumLength = ModelsConstant.PersonNameMaxLength,
            ErrorMessage = ModelsConstant.PersonLastName)]
        public string? LastName { get; set; }
    }
}
