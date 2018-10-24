﻿using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Ingredient : Entity, IIngredient
    {
        public IProduct Product { get; set; }
        public Unit Amount { get; set; }

        public Ingredient()
        {
            
        }
    }
}
