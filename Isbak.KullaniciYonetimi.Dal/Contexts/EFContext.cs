using Isbak.KullaniciYonetimi.Entities.Roles;
using Isbak.KullaniciYonetimi.Entities.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbak.KullaniciYonetimi.Dal.Contexts
{
    public class EFContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public EFContext() : base ("EFContext")
        {
            Database.SetInitializer(new DbOlustur());
        }
    }
    public class DbOlustur : CreateDatabaseIfNotExists<EFContext>
    {
        protected override void Seed(EFContext context)
        {

            Role role = new Role();
            role.RoleName = "admin";
            context.SaveChanges();

            User user = new User();
            user.Username = "aykut";
            user.Email = "aykutonall@gmail.com";
            user.Password = "12345";
            user.Role = role;

            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
