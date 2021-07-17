using Microsoft.EntityFrameworkCore;  
using System.Collections.Generic;  
using System.Linq;  
  
namespace SukantAvalara.Api.Data  
{  
    public class SukantAvalaraDataContext : DbContext  
    {  
        public DbSet<TaskList> TaskList { get; set; }  
        public DbSet<ToDoTaskDb> ToDoTaskDb { get; set; }  
  
        public SukantAvalaraDataContext(DbContextOptions<SukantAvalaraDataContext> options) : base(options)  
        {  
 
        }  
  
    }  
}  