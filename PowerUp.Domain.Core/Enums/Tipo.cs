using System.ComponentModel.DataAnnotations;

namespace PowerUp.Domain.Core.Enums
{
    public enum Tipo
    {
        [Display(Name = "Veicular")]
        Veicular,
        [Display(Name = "Móvel")]
        Movel
    }
}