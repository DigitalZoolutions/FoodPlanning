using System;
using System.Collections.Generic;
using System.Linq;
using FoodPlanning.Extensions;
using FoodPlanning.Features.ApplicationCore;
using FoodPlanning.Models;

namespace FoodPlanning.Features.FoodSchedule
{
    public class FoodScheduleViewModel : BaseViewModel, IFoodScheduleViewModel
    {
        public List<PlanningWeek> PlanningCollection { get; set; }

        public FoodScheduleViewModel()
        {
            List<PlanningItem> plannedItems = new List<PlanningItem>()
            {
                new PlanningItem
                {
                    Date = DateTime.Now,
                    Recipe = new Recipe
                    {
                        Name = "Pizza"
                    }
                },
                new PlanningItem
                {
                    Date = DateTime.Now.AddDays(1),
                    Recipe = new Recipe
                    {
                        Name = "Lasagna"
                    }
                },
                new PlanningItem
                {
                    Date = DateTime.Now.AddDays(2),
                    Recipe = new Recipe
                    {
                        Name = "Soup Minestrone"
                    }
                },
                new PlanningItem
                {
                    Date = DateTime.Now.AddDays(3),
                    Recipe = new Recipe
                    {
                        Name = "Beef Stew"
                    }
                },
                new PlanningItem
                {
                    Date = DateTime.Now.AddDays(4),
                    Recipe = new Recipe
                    {
                        Name = "Hot dogs"
                    }
                },
                new PlanningItem
                {
                    Date = DateTime.Now.AddDays(5),
                    Recipe = new Recipe
                    {
                        Name = "Pasta and meatballs"
                    }
                },
                new PlanningItem
                {
                    Date = DateTime.Now.AddDays(6),
                    Recipe = new Recipe
                    {
                        Name = "Langos"
                    }
                },
                new PlanningItem
                {
                    Date = DateTime.Now.AddDays(7),
                    Recipe = new Recipe
                    {
                        Name = "Buffé"
                    }
                },
                new PlanningItem
                {
                    Date = DateTime.Now.AddDays(8),
                    Recipe = new Recipe
                    {
                        Name = "Hamburger"
                    }
                },
            };

            var thisWeek = plannedItems.FindAll(x => x.WeekNumber == DateTime.Now.GetWeekNumberFromDate());
            var nextWeek = plannedItems.FindAll(x => x.WeekNumber == DateTime.Now.AddDays(7).GetWeekNumberFromDate());

            PlanningCollection = new List<PlanningWeek>();
            
            PlanningCollection.Add(new PlanningWeek("Week " + thisWeek.FirstOrDefault()?.WeekNumber.ToString(), thisWeek));
            PlanningCollection.Add(new PlanningWeek("Week " + nextWeek.FirstOrDefault()?.WeekNumber.ToString(), nextWeek));
        }
    }
}