
﻿using FairyGruppProjekt.Controllers;
using FairyGruppProjekt.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FairyGruppProjekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {



        }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<UsedCurrency> usedCurrencies { get; set; }
 



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Borr & Diamanter" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Kontor & Väntrum" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Hygien & Rengöring" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Blekning & Tandvård"});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Sprutor & Kanyler" });

           

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Borr hårdmetall",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.",
                ImageThumbnailUrl = "\\images2\\borr.jpg",
                IsInStock = true,
                IsOnSale = false,
                Price = 79.90M,
                CategoryId = 1,
                Amount = 20

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Borr hårdmetall",
                Price = 89.50M,
                Description = "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.",
                CategoryId = 1,
                ImageThumbnailUrl = "\\images2\\borr2.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Borr hårdmetall",
                Price = 145.50M,
                Description = "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.",
                CategoryId = 1,
                ImageThumbnailUrl = "\\images2\\borr3.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 30,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Borr hårdmetall",
                Price = 79.50M,
                Description = "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.",
                CategoryId = 1,
                ImageThumbnailUrl = "\\images2\\borr4.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 8
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Classic kaffe brygg",
                Price = 49.50M,
                Description = "Purus sit amet luctus venenatis lectus magna fringilla. Consectetur lorem donec massa sapien faucibus et molestie ac. Sagittis nisl rhoncus mattis rhoncus urna neque viverra.",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\kaffe.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 10
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Kaffe Nescafé",
                Price = 35.50M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\kaffe2.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 150
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Tepåsar 100st",
                Price = 49.50M,
                Description = "Diam sit amet nisl suscipit adipiscing bibendum est ultricies integer. Molestie at elementum eu facilisis sed odio morbi quis commodo. Odio facilisis mauris sit amet massa vitae tortor condimentum lacinia. Urna porttitor rhoncus dolor purus non enim praesent elementum facilisis.",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\te.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 15
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Ytdesinfektion",
                Price = 99.90M,
                Description = "Posuere ac ut consequat semper viverra nam libero justo laoreet. Ultrices dui sapien eget mi proin sed libero enim. Etiam non quam lacus suspendisse faucibus interdum. Amet nisl suscipit adipiscing bibendum est ultricies integer quis.",
                CategoryId = 3,
                ImageThumbnailUrl = "\\images2\\ytdes.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 80
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Ytdesinfektion",
                Price = 79.90M,
                Description = "Ut ornare lectus sit amet est placerat in egestas. Iaculis nunc sed augue lacus viverra vitae. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida. Accumsan tortor posuere ac ut consequat semper viverra.",
                CategoryId = 3,
                ImageThumbnailUrl = "\\images2\\ytdes2.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Handdesinfektion",
                Price = 35M,
                Description = "Vitae congue eu consequat ac felis donec et odio. Tellus orci ac auctor augue mauris augue. Feugiat sed lectus vestibulum mattis ullamcorper velit sed. Sit amet consectetur adipiscing elit pellentesque habitant morbi tristique senectus. Sed pulvinar proin gravida hendrerit lectus a.",
                CategoryId = 3,
                ImageThumbnailUrl = "\\images2\\des.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 120
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Tandborste Gum Junior",
                Price = 12.95M,
                Description = "Hac habitasse platea dictumst quisque sagittis purus sit. Dui nunc mattis enim ut. Mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\tandb.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 30
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                Name = "Brilliant smile Kit",
                Price = 599M,
                Description = "Pulvinar neque laoreet suspendisse interdum consectetur libero id faucibus. Ultrices vitae auctor eu augue ut lectus arcu bibendum at. Vulputate eu scelerisque felis imperdiet proin fermentum.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\blekning.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 15
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 13,
                Name = "Brilliant smile",
                Price = 499M,
                Description = "Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Arcu cursus euismod quis viverra.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\blekning2.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 50
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 14,
                Name = "Perfect Bleach",
                Price = 4995M,
                Description = "Blandit massa enim nec dui nunc mattis enim ut tellus. Duis at consectetur lorem donec massa sapien faucibus et. At auctor urna nunc id cursus metus. Ut enim blandit volutpat maecenas volutpat blandit.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\blek3.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 45
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 15,
                Name = "Colgate tandborste",
                Price = 10.90M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\colgate.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 13
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 16,
                Name = "Colgate Smiles 0-2år",
                Price = 12.50M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\colgate2.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 15
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 17,
                Name = "Colgate Smiles 2-6år",
                Price = 12.50M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\colgate3.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 25
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 18,
                Name = "Colgate Tandkräm",
                Price = 12.50M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\colgate4.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 90
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 19,
                Name = "Colgate Kids 0-5år",
                Price = 12.50M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\colgate5.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 80
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 20,
                Name = "Colgate Smiles 6+",
                Price = 12.50M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\colgate6.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 70
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 21,
                Name = "Flux Junior Munskölj",
                Price = 25M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\flux.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 22,
                Name = "Flux Munskölj",
                Price = 25M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\flux2.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 95
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 23,
                Name = "Flux Munskölj Granate/Mint",
                Price = 25M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\flux3.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 70
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 24,
                Name = "Tandkräm Bamse",
                Price = 16.95M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\bamse.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 50
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 25,
                Name = "Aspiject Spruta",
                Price = 95M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 5,
                ImageThumbnailUrl = "\\images2\\spruta3.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 25
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 26,
                Name = "Dentsply Sirona Irrigation Needle",
                Price = 75M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 5,
                ImageThumbnailUrl = "\\images2\\spruta4.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 25
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 27,
                Name = "Endo spolkanyl",
                Price = 25M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 5,
                ImageThumbnailUrl = "\\images2\\spruta5.jpg",
                IsInStock = true,
                IsOnSale = false,
                Amount = 30
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 28,
                Name = "Kollegieblock Linjerat A4",
                Price = 25M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\kollegie.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 15
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 29,
                Name = "Kopieringspapper 500st",
                Price = 100M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\papper.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 50
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 30,
                Name = "Stiftpenna 12st",
                Price = 35M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\penna.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 10
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 31,
                Name = "Postit Neonkub",
                Price = 25M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\postit.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 70
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 32,
                Name = "Gaffelpärm Blå A4",
                Price = 35M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\pärm.jpg",
                IsInStock = true,
                IsOnSale = true,
                Amount = 53
            });
            modelBuilder.Entity<UsedCurrency>().HasData(new UsedCurrency
            {
                TempKey = 1,
                CurName="SEK",
                CurValue=1
            });


            this.SeedUsers(modelBuilder);
            this.SeedRoles(modelBuilder);
            this.SeedUserRoles(modelBuilder);





        }
        private void SeedUsers(ModelBuilder builder)
        {
            AppUser appuser = new AppUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "admin@random.com",
                Email = "admin@random.com",
                LockoutEnabled = false,
                NormalizedEmail = "ADMIN@RANDOM.COM",
                NormalizedUserName = "ADMIN@RANDOM.COM",

            };

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            appuser.PasswordHash = passwordHasher.HashPassword(appuser, "Admin*123");

            builder.Entity<AppUser>().HasData(appuser);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "HR", ConcurrencyStamp = "2", NormalizedName = "Human Resource" }
                );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" }
                );
        }

    }


}
