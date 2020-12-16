using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alum2
{
    class Alumnos : Personaa
    {
       private int legajo;
       private  double nota1, nota2, nota3;
        //Constructores:
        public Alumnos():base()
        {
            legajo = 0;
            
            nota1 = nota2 = nota3 = 0;
        }
        public Alumnos(int l, double n1, double n2, double n3,string ape,string nom,int tipod,int dni,bool sex,DateTime fechaNac):base(ape,nom,tipod,dni,sex,fechaNac)
        {
            legajo = l;
            
            nota1 = n1;
            nota2 = n2;
            nota3 = n3;

        }
        public int pLegajo
        {
            set { legajo = value; }
            get { return legajo; }
        }
       
        public double pNota1
        {
            set { nota1 = value; }
            get { return nota1; }
        }
        public double pNota2
        {
            set { nota2 = value; }
            get { return nota2; }
        }
        public double pNota3
        {
            set { nota3 = value; }
            get { return nota3; }
        }
        //Métodos:
        public double calcularPromedio()
        {
            return (nota1 + nota2 + nota3) / 3;

        }
       public string toStringAlumnos()
        {
            return "Legajo:"+ legajo + "Nombre:" + base.toString() + "Nota1:"+ nota1.ToString() + "Nota2:"+nota2.ToString() + "Nota3:"+ nota3.ToString();
        }
    }

 }

