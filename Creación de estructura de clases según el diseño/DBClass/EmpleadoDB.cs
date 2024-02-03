using Creación_de_estructura_de_clases_según_el_diseño.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creación_de_estructura_de_clases_según_el_diseño.DBClass
{
    public class EmpleadosDB : Interface
    {
        private readonly List<MiembrosDeLaComunidad> personas;

        public EmpleadosDB()
        {
            this.personas = new List<MiembrosDeLaComunidad>();
        }

        public void Add(MiembrosDeLaComunidad persona)
        {
            this.personas.Add(persona);
        }

        public void Update(MiembrosDeLaComunidad persona)
        {
            this.personas.Add(persona);
        }

        public void Remove(MiembrosDeLaComunidad persona)
        {
            this.personas.Remove(persona);
        }

        public bool Exits(MiembrosDeLaComunidad persona)
        {
            return this.personas.Exists(cd => cd.FirstName == persona.FirstName);
        }
    }
}
