using System;

namespace alumnoNombreMatricula
{
    class Alumno
    { 
         public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public int [] Calificaciones  { get; set; }

        public Alumno(int cantidadCalificaciones)
        { 
         Calificaciones = new int[ cantidadCalificaciones];
        }
        public double CalcularPromedio()
        {
         int suma =0;
            foreach (int calificacion in Calificaciones)
            { 
                suma += calificacion;
            }
            return (double)suma / Calificaciones.Length;
        }
        public void  MostrarInformacion()
        {
            Console.WriteLine($"Nombre {Nombre}");

            Console.WriteLine($"Matricula {Matricula}");
            Console.WriteLine($"Carrera {Carrera}");


            Console.WriteLine($"Promedio {CalcularPromedio()}");



        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno(4)
            {
               Nombre = " Delvin villar",
                Matricula = " A20231586",
               Carrera = " Ingeneria en Sistemas",
            };
            alumno1.Calificaciones[0] = 95;
            alumno1.Calificaciones[1] = 85;
            alumno1.Calificaciones[2] = 90;
            alumno1.Calificaciones[3] = 80;

            alumno1.MostrarInformacion();
            Alumno alumno2 = new Alumno(4)
            {
                Nombre = " Nicol Sierra",
                Matricula = " A20221586",
                Carrera = " Ingeneria civil",
            };

                alumno2.Calificaciones[0] = 85;
                alumno2.Calificaciones[1] =78;
                alumno2.Calificaciones[2] = 90;
                alumno2.Calificaciones[3] = 80;

           alumno2.MostrarInformacion();
        }

    }
}
