using System;
using FoodPlanning.Extensions;

namespace FoodPlanning.Models
{
    public class PlanningItem
    {
        public DateTime Date { get; set; }
        public string DayOfWeekName => Date.DayOfWeek.ToString();
        public int WeekNumber => Date.GetWeekNumberFromDate();
        public Recipe Recipe { get; set; }
    }
}