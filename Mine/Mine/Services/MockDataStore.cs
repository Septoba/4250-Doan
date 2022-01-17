using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mine.Models;

namespace Mine.Services
{
    public class MockDataStore : IDataStore<ItemModel>
    {
        readonly List<ItemModel> items;

        public MockDataStore()
        {
            items = new List<ItemModel>()
            {
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Ray Gun", Description="Shoots Lasers.", Value = 7 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Rope", Description="Tie down your enemies.", Value = 3},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Curved Sword", Description="Slashes through your enemies like butter.", Value = 9 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Laser Watch", Description="Shoots a small laser.", Value = 5 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Fancy Boots", Description="Can't do your job without class.", Value = 2 },
            };
        }

        public async Task<bool> AddItemAsync(ItemModel item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(ItemModel item)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ItemModel> ReadAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ItemModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}