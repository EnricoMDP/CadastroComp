using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroComp.Models;

namespace CadastroComp.Data
{
    public class CadastroCompContext : DbContext
    {
        public CadastroCompContext (DbContextOptions<CadastroCompContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroComp.Models.Cliente> Cliente { get; set; } = default!;
    }
}
