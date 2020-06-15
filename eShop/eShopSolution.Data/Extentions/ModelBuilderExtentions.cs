using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extentions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //// Data Seeding
            //modelBuilder.Entity<AppConfig>().HasData(
            //    new AppConfig() { Key = "HomeTitle", Value = "This is Home page of eShopSolution" },
            //    new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
            //    new AppConfig() { Key = "HomeDescription", Value = "This is Description of eShopSolution" }
            //    );
            //modelBuilder.Entity<Language>().HasData(
            //    new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true},
            //    new Language() { Id = "en-US", Name = "English", IsDefault = false}
            //    );
            //modelBuilder.Entity<Category>().HasData(
            //    new Category() { Id = 1, IsShowOnHome = true, ParrentId = null, SortOrder = 1, Status = Status.Active,

            //    }
            //    ) ;
            //// Data Seeding
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole() {Id = roleId, Name= "admin", NormalizedName="admin",ConcurrencyStamp= "stamp1", Description= "abczxyzxasx" }
                );
        }
    }
}
