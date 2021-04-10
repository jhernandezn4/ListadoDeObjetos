using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.clases;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ruta = this.txtRuta.Text;

            clsArchivo archivo = new clsArchivo(ruta);
            List<alumno> datos = archivo.leerArchivo();


            
            List<alumno> arreglo = datos;
            List<alumno> ArregloTemporal = arreglo;
            alumno datosTemporal;


            for (int i = 0; i < arreglo.Count - 1; i++)
            {
                for (int j = i + 1; j < arreglo.Count; j++)
                {
                    /**
                     *  COMO NO ES UN NUMERO SE UTILIZA EL COMPARE.TO 
                     *  PARA COMPARAR LOS 2 STRING POR ORDEN ALFABETICO
                     */
                    if (ArregloTemporal[i].ParcialUno > ArregloTemporal[j].ParcialUno)
                    {
                        datosTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datosTemporal;
                    }
                }
            }

            foreach(alumno info in arreglo)
            {
                this.listAlumnos.Items.Add(info.ParcialUno);
            }


        }

        
    }
}
