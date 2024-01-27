using System.ComponentModel.DataAnnotations;

namespace TrainsApi.Data.Enums
{
    public enum TrainType
    {
        [Display(Name ="Fast train")]
        FAST = 0,
        [Display(Name ="Passenger train")]
        PASSENGER = 1,
        [Display(Name ="Intercity passenger train")]
        INTER_CITY = 2,
        [Display(Name ="Freight train")]
        FREIGHT = 3,
        [Display(Name ="Maintenance train")]
        MAINTENANCE = 4
    }
}