using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creación_de_estructura_de_clases_según_el_diseño.Clases
{
    public interface Interface
    {
        void Add(MiembrosDeLaComunidad persona);
        void Update(MiembrosDeLaComunidad persona);
        void Remove(MiembrosDeLaComunidad persona);
        bool Exits(MiembrosDeLaComunidad persona);
    }
}
