﻿using CookBook.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookBook.BL.Web.Blazor.Facades
{
    public interface IIngredientsFacade
    {
        Task<IList<IngredientListModel>> IngredientsGetAsync();
    }
}