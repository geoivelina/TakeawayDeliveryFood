using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeawayDeliveryFood.Infrastructure.Data.Configuration
{
    //internal class UserConfiguration : IEntityTypeConfiguration<User>
    //{
        //public void Configure(EntityTypeBuilder<User> builder)
        //{
        //    builder.HasData(CreateGuestUsers());
        //}

        //private List<User> CreateGuestUsers()
        //{
        //    var users = new List<User>();
        //    var hasher = new PasswordHasher<User>();


        //    var user = new User()
        //    {
        //        Id= "6615ac78-a9b6-4271-9192-ccf57b610779",
        //        UserName = "admin",
        //        NormalizedUserName = "ADMIN",
        //        Email = "admin@mail.com",
        //        NormalizedEmail = "ADMIN@MAIL.COM",
        //        FullName = "AdminUser",
        //        Address = "FancyAddress"

        //    };
        //    user.PasswordHash = hasher.HashPassword(user, "admin123");

        //    users.Add(user);

        //    user = new User()
        //    {
        //        Id = "dd3df4c6-425c-4da4-9314-7bb1a274ce43",
        //        UserName = "customer",
        //        NormalizedUserName = "CUSTOMER",
        //        Email = "customer@mail.com",
        //        NormalizedEmail = "CUSTOMER@MAIL.COM",
        //        FullName = "CustomerUser",
        //        Address = "FancyAddress"

        //    };
        //    user.PasswordHash = hasher.HashPassword(user, "customer123");

        //    users.Add(user);
        //    return users;
        //}
    //}
}
