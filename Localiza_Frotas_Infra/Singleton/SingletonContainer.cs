using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza_Frotas_Infra.Singleton
{
    public class SingletonContainer
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
