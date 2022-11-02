
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


            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Dental drills" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Office & Lounge" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Hygiene & Cleaning" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Whitening & Dental care"});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Syringes & Cannula" });

           

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Dental drill metal 390/008",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.",
                ImageThumbnailUrl = "\\images2\\borr.jpg",
                IsOnSale = false,
                Price = 79.90M,
                CategoryId = 1,
                AmountOfCopiesInStorage = 20

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Dental drill metal 180/012",
                Price = 89.50M,
                Description = "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.",
                CategoryId = 1,
                ImageThumbnailUrl = "\\images2\\borr2.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Dental drill metal 390/012",
                Price = 145.50M,
                Description = "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.",
                CategoryId = 1,
                ImageThumbnailUrl = "\\images2\\borr3.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 30,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Dental drill metal 010/012",
                Price = 79.50M,
                Description = "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.",
                CategoryId = 1,
                ImageThumbnailUrl = "\\images2\\borr4.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 8
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Classic brew coffe",
                Price = 49.50M,
                Description = "Purus sit amet luctus venenatis lectus magna fringilla. Consectetur lorem donec massa sapien faucibus et molestie ac. Sagittis nisl rhoncus mattis rhoncus urna neque viverra.",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\kaffe.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 10
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Coffe Nescafé",
                Price = 35.50M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\kaffe2.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 150
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Tea, 100 Teabags",
                Price = 49.50M,
                Description = "Diam sit amet nisl suscipit adipiscing bibendum est ultricies integer. Molestie at elementum eu facilisis sed odio morbi quis commodo. Odio facilisis mauris sit amet massa vitae tortor condimentum lacinia. Urna porttitor rhoncus dolor purus non enim praesent elementum facilisis.",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\te.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 15
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Surface disinfection",
                Price = 99.90M,
                Description = "Posuere ac ut consequat semper viverra nam libero justo laoreet. Ultrices dui sapien eget mi proin sed libero enim. Etiam non quam lacus suspendisse faucibus interdum. Amet nisl suscipit adipiscing bibendum est ultricies integer quis.",
                CategoryId = 3,
                ImageThumbnailUrl = "\\images2\\ytdes.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 80
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Surface disinfection",
                Price = 79.90M,
                Description = "Ut ornare lectus sit amet est placerat in egestas. Iaculis nunc sed augue lacus viverra vitae. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida. Accumsan tortor posuere ac ut consequat semper viverra.",
                CategoryId = 3,
                ImageThumbnailUrl = "\\images2\\ytdes2.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Hand disinfection",
                Price = 35M,
                Description = "Vitae congue eu consequat ac felis donec et odio. Tellus orci ac auctor augue mauris augue. Feugiat sed lectus vestibulum mattis ullamcorper velit sed. Sit amet consectetur adipiscing elit pellentesque habitant morbi tristique senectus. Sed pulvinar proin gravida hendrerit lectus a.",
                CategoryId = 3,
                ImageThumbnailUrl = "\\images2\\des.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 120
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Toothbrush Gum Junior",
                Price = 12.95M,
                Description = "Hac habitasse platea dictumst quisque sagittis purus sit. Dui nunc mattis enim ut. Mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\tandb.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 30
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                Name = "Brilliant Smile Kit",
                Price = 599M,
                Description = "Pulvinar neque laoreet suspendisse interdum consectetur libero id faucibus. Ultrices vitae auctor eu augue ut lectus arcu bibendum at. Vulputate eu scelerisque felis imperdiet proin fermentum.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\blekning.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 15
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 13,
                Name = "Brilliant Smile",
                Price = 499M,
                Description = "Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Arcu cursus euismod quis viverra.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\blekning2.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 50
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 14,
                Name = "Perfect Bleach",
                Price = 4995M,
                Description = "Blandit massa enim nec dui nunc mattis enim ut tellus. Duis at consectetur lorem donec massa sapien faucibus et. At auctor urna nunc id cursus metus. Ut enim blandit volutpat maecenas volutpat blandit.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\blek3.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 45
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 15,
                Name = "Colgate toothbrush",
                Price = 10.90M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\colgate.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 13
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 16,
                Name = "Colgate Smiles 0-2 years",
                Price = 12.50M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\colgate2.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 15
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 17,
                Name = "Colgate Smiles 2-6 years",
                Price = 12.50M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\colgate3.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 25
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 18,
                Name = "Colgate Toothpaste",
                Price = 12.50M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\colgate4.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 90
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 19,
                Name = "Colgate Kids 0-5 years",
                Price = 12.50M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,            
                ImageThumbnailUrl = "\\images2\\colgate5.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 80
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 20,
                Name = "Colgate Smiles 6+",
                Price = 12.50M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\colgate6.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 70
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 21,
                Name = "Flux Junior Mouthwash",
                Price = 25M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\flux.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 100
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 22,
                Name = "Flux Mouthwash",
                Price = 25M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\flux2.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 95
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 23,
                Name = "Flux Mouthwash Granate/Mint",
                Price = 25M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\flux3.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 70
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 24,
                Name = "Toothpaste Bamse",
                Price = 16.95M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 4,
                ImageThumbnailUrl = "\\images2\\bamse.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 50
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 25,
                Name = "Aspiject Syringe",
                Price = 95M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 5,
                ImageThumbnailUrl = "\\images2\\spruta3.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 25
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 26,
                Name = "Dentsply Sirona Irrigation Needle",
                Price = 75M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 5,
                ImageThumbnailUrl = "\\images2\\spruta4.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 25
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 27,
                Name = "Endo Cannula",
                Price = 25M,
                Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                CategoryId = 5,
                ImageThumbnailUrl = "\\images2\\spruta5.jpg",
                IsOnSale = false,
                AmountOfCopiesInStorage = 30
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 28,
                Name = "Collegiate block Lined A4",
                Price = 25M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\kollegie.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 15
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 29,
                Name = "A4 paper, 500 bundle",
                Price = 100M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\papper.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 50
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 30,
                Name = "Ballpoint pen 12 bundle",
                Price = 35M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\penna.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 10
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 31,
                Name = "Post-it notes",
                Price = 25M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\postit.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 70
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 32,
                Name = "Folder Blue A4",
                Price = 35M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageThumbnailUrl = "\\images2\\pärm.jpg",
                IsOnSale = true,
                AmountOfCopiesInStorage = 53
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
