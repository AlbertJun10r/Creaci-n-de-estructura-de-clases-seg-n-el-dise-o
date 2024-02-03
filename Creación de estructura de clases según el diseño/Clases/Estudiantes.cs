using Creación_de_estructura_de_clases_según_el_diseño.DBClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creación_de_estructura_de_clases_según_el_diseño.Clases
{
    public class Estudiantes : MiembrosDeLaComunidad
    {
        private readonly Interface studiantesDB;
        public Estudiantes()
        {
            this.studiantesDB = new EstudiantesDB();
        }
        public override void Save()
        {

            //Guardar la informacion en la tabla estudiante
            this.studiantesDB.Add(new Estudiantes() { });
        }

        public override void Update()
        {
            // se aplica el update para estudiantes
            this.studiantesDB.Update(new Estudiantes() { });
        }
    }
}
