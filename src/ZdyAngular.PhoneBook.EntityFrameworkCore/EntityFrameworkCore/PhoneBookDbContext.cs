using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ZdyAngular.PhoneBook.Authorization.Roles;
using ZdyAngular.PhoneBook.Authorization.Users;
using ZdyAngular.PhoneBook.MultiTenancy;
using ZdyAngular.PhoneBook.PhoneBooks.Persons;
using ZdyAngular.PhoneBook.PhoneBooks.PhoneNumbers;

namespace ZdyAngular.PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
    }
}
