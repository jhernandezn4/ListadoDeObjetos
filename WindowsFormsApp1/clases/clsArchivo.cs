using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1.clases
{
    class clsArchivo
    {

        private string ruta { get; set; }
        List<alumno> listaAlumnos = new List<alumno>();
        public clsArchivo(string ruta)
        {
            this.ruta = ruta;
        }
        public List<alumno> leerArchivo()
        {
            string[] archivo = File.ReadAllLines(this.ruta);
            archivo = archivo.Skip(1).ToArray();

            foreach(String fila in archivo)
            {
                string[] columnas = fila.Split(',');

                alumno info = new alumno(columnas[0], columnas[1], columnas[2], columnas[3], columnas[4]);
                this.listaAlumnos.Add(info);
            }    
            return this.listaAlumnos;
        }
    }
}
