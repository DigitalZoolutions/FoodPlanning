using System.Collections.Generic;
using FoodPlanning.Models;

namespace FoodPlanning.Features.FoodSchedule
{
    public class PlanningWeek
    {
        public string WeekNumber { get; set; }
        public List<PlanningItem> PlanningItems { get; set; }

        public PlanningWeek(string weekNumber, List<PlanningItem> items)
        {
            this.WeekNumber = weekNumber;
            this.PlanningItems = items;
        }
    }
}