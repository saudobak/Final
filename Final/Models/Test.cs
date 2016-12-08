using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace Final.Models
{
    public class Test
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }

    public class TestDBContext : DbContext
    {
        public DbSet<Test> Movies { get; set; }
    }
}