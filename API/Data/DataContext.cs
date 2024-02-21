using System.Data.Common;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Data; 

public class DataContext: DbContext {
     public DataContext(DbContextOptions options) : base(options) {
     }
     public DbSet<AppUser> Users {get; set;}

}  