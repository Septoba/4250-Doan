﻿using System;
using SQLite;

namespace Mine.Models
{
    /// <summary>
    ///  Items for the Charaters and Monster to Use
    /// </summary>
    public class ItemModel
    {
        // The Id for the Item
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        
        // The Display Text for the Item
        public string Text { get; set; }

        // The Description for the Item
        public string Description { get; set; }
        
        // The Value of the Item +9 Damage
        public int Value { get; set; } = 0;
    }
}