﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Threading.Tasks;
using proiect2.Models;

namespace proiect2.Data
{
    public class RecipeDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public RecipeDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<RecipeList>().Wait();
        }
        public Task<List<RecipeList>> GetRecipeListsAsync()
        {
            return _database.Table<RecipeList>().ToListAsync();
        }
        public Task<RecipeList> GetRecipeListAsync(int id)
        {
            return _database.Table<RecipeList>()
            .Where(i => i.Id == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveRecipeListAsync(RecipeList slist)
        {
            if (slist.Id != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteRecipeListAsync(RecipeList slist)
        {
            return _database.DeleteAsync(slist);
        }
    }
}
