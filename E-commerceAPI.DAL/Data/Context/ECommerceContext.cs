using E_CommerceProject.DAL.Data.Models;
using E_CommerceProject.DAL.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace E_CommerceProject.DAL.Data.Context
{
    public class ECommerceContext : IdentityDbContext<User>
    {
        #region Mapping 
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        #endregion

        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Relation Fluent Api

            modelBuilder.Entity<User>()
                        .HasOne(u => u.Cart)
                        .WithOne(c => c.User)
                        .HasForeignKey<Cart>(c => c.UserId);
            #endregion

            #region Seeding Category
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Home Appliances", Description = "Home Appliances category description" },
                new Category { Id = 2, Name = "Sports", Description = "Sports category description" },
                new Category { Id = 3, Name = "Smartphones", Description = "Smartphones category description" },
                new Category { Id = 4, Name = "Laptops", Description = "Laptops category description" },
                new Category { Id = 5, Name = "Books", Description = "Books category description" },
                new Category { Id = 6, Name = "Furniture", Description = "Furniture category description" },
                new Category { Id = 7, Name = "Clothing", Description = "Clothing category description" },
                new Category { Id = 8, Name = "Toys", Description = "Toys category description" },
                new Category { Id = 9, Name = "Electronics", Description = "Electronics category description" },
                new Category { Id = 10, Name = "Beauty & Health", Description = "Beauty & Health category description" }
            };
            #endregion

            #region Seeding Products
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Amazon Kindle Paperwhite", Rate = 4, Description = "8 GB Storage, Waterproof, 6.8-inch Display, Adjustable Warm Light - Black", Price = 12000, Count = 20, CategoryId = 5 },
                new Product { Id = 2, Name = "Philips Sonicare DiamondClean Toothbrush", Rate = 5, Description = "Electric, Rechargeable, 5 Modes, Travel Case - White", Price = 15000, Count = 12, CategoryId = 10 },
                new Product { Id = 3, Name = "Sony WH-1000XM4", Rate = 5, Description = "Industry Leading Noise Canceling Overhead Headphones, Wireless, Bluetooth, 30 Hours Battery Life - Black", Price = 20000, Count = 15, CategoryId = 1 },
                new Product { Id = 4, Name = "HP Spectre x360", Rate = 4, Description = "2-in-1 Laptop, 11th Gen Intel Core i7, 16GB RAM, 1TB SSD, 13.3-inch FHD Touch Display, Windows 10 - Nightfall Black", Price = 85000, Count = 8, CategoryId = 2 },
                new Product { Id = 5, Name = "Apple 2022 MacBook", Rate = 4, Description = "Apple 2022 MacBook Air laptop with M2 chip: 13.6-inch Liquid Retina display, 8GB RAM, 256GB SSD storage, 1080p FaceTime HD camera. Works with iPhone and iPad; Space Grey;", Price = 59750, Count = 5, CategoryId = 2 },
                new Product { Id = 6, Name = "Bosch Serie 6 Washing Machine", Rate = 4, Description = "9 kg, Front Load, Fully Automatic, EcoSilence Drive, 1400 RPM - White", Price = 40000, Count = 7, CategoryId = 4 },
                new Product { Id = 7, Name = "Nike Air Zoom Pegasus 38", Rate = 5, Description = "Men's Running Shoes, Comfortable Fit, Durable, Size 10 - Black", Price = 8000, Count = 30, CategoryId = 7 },
                new Product { Id = 8, Name = "LEGO Star Wars Millennium Falcon", Rate = 5, Description = "Building Kit, Collectible Model, Ages 16+, 7541 Pieces", Price = 55000, Count = 10, CategoryId = 8 },
                new Product { Id = 9, Name = "Wilson Evolution Game Basketball", Rate = 4, Description = "Official Size, Indoor Use, High-Quality Composite Leather - Orange", Price = 4500, Count = 25, CategoryId = 9 },
                new Product { Id = 10, Name = "Amazon Kindle Paperwhite", Rate = 4, Description = "8 GB Storage, Waterproof, 6.8-inch Display, Adjustable Warm Light - Black", Price = 12000, Count = 20, CategoryId = 5 },
            };
            #endregion

            #region Seeding Users
            var users = new List<User>
            {
                new User { Id = "1", UserName = "aya", Email = "aya@example.com", Age = 23, Address = "123 Street,NewYork City", Gender = Gender.Female },
                new User { Id = "2", UserName = "farah", Email = "farah@example.com", Age = 25, Address = "456 Avenue, Town", Gender = Gender.Female },
                new User { Id = "3", UserName = "rahma", Email = "rahma@example.com", Age = 35, Address = "789 Boulevard, Metropolis", Gender = Gender.Female },
                new User { Id = "4", UserName = "amal", Email = "amal@example.com", Age = 28, Address = "1010 Way, Village", Gender = Gender.Female },
                new User { Id = "5", UserName = "fadia", Email = "fadia@example.com", Age = 22, Address = "1111 Road, Hamlet", Gender = Gender.Female },
                new User { Id = "6", UserName = "zain", Email = "rawan@example.com", Age = 40, Address = "1212 Parkway, Borough", Gender = Gender.Male },
                new User { Id = "7", UserName = "menna", Email = "menna@example.com", Age = 33, Address = "1313 Plaza, City", Gender = Gender.Female },
                new User { Id = "8", UserName = "ahmed", Email = "ahmed@example.com", Age = 27, Address = "1414 Terrace, Town", Gender = Gender.Male },
                new User { Id = "9", UserName = "mohamed", Email = "mohamed@example.com", Age = 24, Address = "1515 Court, Metropolis", Gender = Gender.Male },
                new User { Id = "10", UserName = "alaa", Email = "alaa@example.com", Age = 29, Address = "1616 Lane, Village", Gender = Gender.Male }
            };
            #endregion

            #region Seedin Cart
            var carts = new List<Cart>
            {
            new Cart { ID = 1, UserId = "1" },
            new Cart { ID = 2, UserId = "2" },
            new Cart { ID = 3, UserId = "3" },
            new Cart { ID = 4, UserId = "4" },
            new Cart { ID = 5, UserId = "5" },
            new Cart { ID = 6, UserId = "6" },
            new Cart { ID = 7, UserId = "7" },
            new Cart { ID = 8, UserId = "8" },
            new Cart { ID = 9, UserId = "9" },
            new Cart { ID = 10, UserId = "10" }
            };
            #endregion

            #region Seeding CartItems 
            var cartItems = new List<CartItem>
            {
                new CartItem { ID = 1, Quantity = 2, Price = 4500, CreatedDate = DateTime.Now, CartId = 6, ProductId = 9 },
                new CartItem { ID = 2, Quantity = 1, Price = 15000, CreatedDate = DateTime.Now, CartId = 6, ProductId = 10 },
                new CartItem { ID = 3, Quantity = 1, Price = 66666, CreatedDate = DateTime.Now, CartId = 2, ProductId = 1 },
                new CartItem { ID = 4, Quantity = 1, Price = 59750, CreatedDate = DateTime.Now, CartId = 2, ProductId = 2 },
                new CartItem { ID = 5, Quantity = 2, Price = 40000, CreatedDate = DateTime.Now, CartId = 3, ProductId = 6 },
                new CartItem { ID = 6, Quantity = 1, Price = 20000, CreatedDate = DateTime.Now, CartId = 3, ProductId = 3 },
                new CartItem { ID = 7, Quantity = 3, Price = 12000, CreatedDate = DateTime.Now, CartId = 4, ProductId = 5 },
                new CartItem { ID = 8, Quantity = 1, Price = 85000, CreatedDate = DateTime.Now, CartId = 4, ProductId = 4 },
                new CartItem { ID = 9, Quantity = 1, Price = 8000, CreatedDate = DateTime.Now, CartId = 5, ProductId = 7 },
                new CartItem { ID = 10, Quantity = 1, Price = 55000, CreatedDate = DateTime.Now, CartId = 5, ProductId = 8 }
            };
            #endregion

            #region Seeding Orders
            var orders = new List<Order>
            {
                new Order { ID = 1, TotalPrice = 32000, CreatedDateTime = DateTime.Now, UserId = "1" },
                new Order { ID = 2, TotalPrice = 34000, CreatedDateTime = DateTime.Now, UserId = "2" },
                new Order { ID = 3, TotalPrice = 18000, CreatedDateTime = DateTime.Now, UserId = "3" },
                new Order { ID = 4, TotalPrice = 59750, CreatedDateTime = DateTime.Now, UserId = "4" },
                new Order { ID = 5, TotalPrice = 80000, CreatedDateTime = DateTime.Now, UserId = "5" },
                new Order { ID = 6, TotalPrice = 3500, CreatedDateTime = DateTime.Now, UserId = "6" },
                new Order { ID = 7, TotalPrice = 33000, CreatedDateTime = DateTime.Now, UserId = "7" },
                new Order { ID = 8, TotalPrice = 15000, CreatedDateTime = DateTime.Now, UserId = "8" },
                new Order { ID = 9, TotalPrice = 2500, CreatedDateTime = DateTime.Now, UserId = "9" },
                new Order { ID = 10, TotalPrice = 7166, CreatedDateTime = DateTime.Now, UserId = "10" }
            };
            #endregion

            #region Seeding OrderItems
            var orderItems = new List<OrderItem>
            {
                new OrderItem { Id = 1, PriceTotal = 66000, OrderId = 7, ProductId = 1 },
                new OrderItem { Id = 2, PriceTotal = 119500, OrderId = 7, ProductId = 2 },
                new OrderItem { Id = 3, PriceTotal = 40000, OrderId = 3, ProductId = 6 },
                new OrderItem { Id = 4, PriceTotal = 20000, OrderId = 3, ProductId = 3 },
                new OrderItem { Id = 5, PriceTotal = 24000, OrderId = 4, ProductId = 5 },
                new OrderItem { Id = 6, PriceTotal = 85000, OrderId = 4, ProductId = 4 },
                new OrderItem { Id = 7, PriceTotal = 8000, OrderId = 5, ProductId = 7 },
                new OrderItem { Id = 8, PriceTotal = 55000, OrderId = 5, ProductId = 8 },
                new OrderItem { Id = 9, PriceTotal = 9000, OrderId = 6, ProductId = 9 },
                new OrderItem { Id = 10, PriceTotal = 30000, OrderId = 6, ProductId = 10 },
            };
            #endregion


            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Cart>().HasData(carts);
            modelBuilder.Entity<CartItem>().HasData(cartItems);
            modelBuilder.Entity<Order>().HasData(orders);
            modelBuilder.Entity<OrderItem>().HasData(orderItems);
        }


    }
}
