﻿namespace WarehouseApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //lista produktow
        public List<Product>? products { get; set; }

    }
}
