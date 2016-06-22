﻿using InternetShopCosmetics.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;

namespace InternetShopCosmetics.DAL
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            // код добавления пользователей в базу данных 

            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //ICollection<ApplicationUser> usersList = new List<ApplicationUser>();
            //Random rnd = new Random();

            //ApplicationUser user = new ApplicationUser()
            //{
            //    UserName = "Admin",
            //    Id = "Admin"
            //};
            //IdentityRole role = new IdentityRole("admin");

            //userManager.Create(user, "password");
            //roleManager.Create(role);
            //userManager.AddToRole(user.Id, role.Name);
            //usersList.Add(user);

            //ApplicationUser user1 = new ApplicationUser()
            //{
            //    UserName = "Ekaterina",
            //    Id = "User1"
            //};
            //IdentityRole role1 = new IdentityRole("simple_user");


            //userManager.Create(user1, "111111");
            //roleManager.Create(role1);
            //userManager.AddToRole(user1.Id, role1.Name);
            //usersList.Add(user1);

            //ApplicationUser user2 = new ApplicationUser()
            //{
            //    UserName = "Darya",
            //    Id = "User2"
            //};
            //IdentityRole role2 = new IdentityRole("simple_user");


            //userManager.Create(user2, "222222");
            //roleManager.Create(role2);
            //userManager.AddToRole(user2.Id, role2.Name);
            //usersList.Add(user2);

            List<Product> Products = new List<Product>();

            for (int i = 1; i <= 10; i++)
            {
                Product product = new Product()
                {

                    Name = "Название продукта " + i,
                    Description = GenerateSeedDescription(i),
                };

                context.Products.Add(product);
            }

            context.SaveChanges();
        }


        string GenerateSeedDescription(int i)
        {
            StringBuilder sb = new StringBuilder();
            // sb.Append("Message " + i+"\n");
            for (int k = 0; k < 2; k++)
            {
                sb.Append("текст описания ");
                sb.Append(i);
                sb.Append(" ");
            }
            sb.Append("\n");
            return sb.ToString();
        }
    }
}