using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exemplo_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace exemplo_api.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext()
        {
            
        }
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contato{ get; set; }
        
    }
}