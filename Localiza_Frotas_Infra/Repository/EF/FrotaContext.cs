using Localiza_Frotas_Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza_Frotas_Infra.EF
{
    public class FrotaContext : DbContext
    {
        public FrotaContext(DbContextOptions<FrotaContext> options)
   : base(options)
        {
        }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
