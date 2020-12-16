using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alum2
{
    class Personaa
    {
        private string nombre, apellido;
       private int tipodoc, doc;
       private bool sexo;
       private DateTime FechaNacimiento;

       public Personaa()
       {
           apellido = "";
           nombre = "";
           tipodoc = 0;
           doc = 0;
           sexo = false;
           FechaNacimiento = DateTime.Today;
       }

       public Personaa(string ape, string nom, int tipod, int dni, bool sex,DateTime fechaNac)
       {
           apellido = ape;
           nombre = nom;
           tipodoc = tipod;
           doc = dni;
           sexo = sex;
           FechaNacimiento = fechaNac;
       }

        public string pNombre
       {
           set { nombre = value; }
           get { return nombre; }
       }

        public string pApellido
       {
           set { apellido = value; }
           get { return apellido; }
       }

        public int pTipoDoc
        {
            set { tipodoc = value; }
            get { return tipodoc; }
        }

        public int pDoc
        {
            set { doc = value; }
            get { return doc; }
        }

        public bool pSexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public DateTime pFechaNacimiento
        {
            set { FechaNacimiento = value; }
            get { return FechaNacimiento; }
        }

    
        public string toStringSexo()
        {
            if (sexo)
                return "Masculino";
            else
                return "Femenino";
        }


          public string toString()
        {
            return apellido + " " + nombre + "  "+
                " " + tipodoc.ToString()
               
         + " " + toStringSexo() + " " + FechaNacimiento.ToShortDateString();
         }
    }
}
