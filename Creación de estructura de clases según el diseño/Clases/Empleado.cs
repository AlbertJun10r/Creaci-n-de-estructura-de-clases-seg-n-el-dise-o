using Creación_de_estructura_de_clases_según_el_diseño.DBClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creación_de_estructura_de_clases_según_el_diseño.Clases
{
    public class Empleado : MiembrosDeLaComunidad
    {
        private readonly Interface mpleadoDB;

        public Empleado()
        {
            this.mpleadoDB = new EmpleadosDB();
        }

        public override void Save()
        {
            this.mpleadoDB.Add(this);
        }

        public override void Update()
        {
            this.mpleadoDB.Update(this);
        }
    }
}