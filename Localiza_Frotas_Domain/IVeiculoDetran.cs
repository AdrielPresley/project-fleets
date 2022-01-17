using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza_Frotas_Domain
{
    public interface IVeiculoDetran
    {
        public Task AgendarVistoriaDetran(Guid veiculoId);
    }
}
