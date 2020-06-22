using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Values is the name of the table
        public DbSet<Value> Values{get;set;}
        public DbSet<User> Users{get;set;}
        public DbSet<Photo> Photos { get; set; }
    }
}