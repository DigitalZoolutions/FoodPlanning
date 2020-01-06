using System.Collections.Generic;
using FoodPlanning.Features.ApplicationCore;

namespace FoodPlanning.Features.FoodSchedule
{
    public interface IFoodScheduleViewModel : IBaseViewModel
    {
        List<PlanningWeek> PlanningCollection { get; set; }
    }
}