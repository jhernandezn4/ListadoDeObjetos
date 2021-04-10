using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.clases
{
    class alumno
    {
        public int Id { get; private set; }
        public string Nombre { get;  set; }

        public int ParcialUno { get;  set; }
        public int ParcialDos { get;  set; }
        public int ParcialTres { get;  set; }

        public alumno(string Id, string Nombre, string ParcialUno, string ParcialDos, string ParcialTres)
        {
            this.Id = Convert.ToInt32(Id);
            this.Nombre = Nombre;
            this.ParcialUno = Convert.ToInt32(ParcialUno);
            this.ParcialDos = Convert.ToInt32(ParcialDos);
            this.ParcialTres = Convert.ToInt32(ParcialTres);
        }
    }
}
