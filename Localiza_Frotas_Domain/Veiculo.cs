using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza_Frotas_Domain
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string AnoFabricacao { get; set; }
    }
}
