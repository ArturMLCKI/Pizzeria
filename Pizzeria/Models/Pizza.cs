﻿namespace Pizzeria.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }  
        public bool IsVegan { get; set; }

    }
}
