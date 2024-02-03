using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creación_de_estructura_de_clases_según_el_diseño.Clases
{
   public abstract class MiembrosDeLaComunidad
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? Email { get; set; }
        public string? Phone { get; set;}

        public abstract void Save();

        public virtual void Update() 
        {
          
        }
    }
}
