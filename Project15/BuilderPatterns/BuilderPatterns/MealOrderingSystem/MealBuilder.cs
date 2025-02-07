using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.MealOrderingSystem
{
    public class MealBuilder
    {
        private readonly Meal _meal = new Meal();

        public MealBuilder setMainDish(string maindish)
        {
            _meal.MainDish = maindish;
            return this;
        }

        public MealBuilder setSideDish(string sideDish)
        {
            _meal.SideDish = sideDish;
            return this;
        }

        public MealBuilder setDrink(string drink)
        {
            _meal.Drink = drink;
            return this;
        }

        public MealBuilder MakeCombo()
        {
            _meal.IsComboMeal = true;
            return this;
        }

        public Meal meal()
        {
            return _meal;
        }
    }
}