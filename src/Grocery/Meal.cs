﻿using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Meal : Entity, IMeal
    {
        public MealType Type { get; set; }
        public Guid RecipyID { get; set; }

        public Meal()
        {
            
        }
    }
}
