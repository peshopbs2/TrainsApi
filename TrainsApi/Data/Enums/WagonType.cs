using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrainsApi.Data.Enums
{
    public enum WagonType
    {
        [Display(Name = "Sleeping wagon")]
        SLEEP = 0,
        [Display(Name = "Coupe wagon")]
        COUPE = 1,
        [Display(Name = "Salon wagon")]
        SALON = 2,
        [Display(Name = "Restaurant wagon")]
        RESTAURANT = 3,
        [Display(Name = "Storage wagon")]
        STORAGE = 4,
        [Display(Name = "Freight wagon")]
        FREIGHT = 5
    }
}