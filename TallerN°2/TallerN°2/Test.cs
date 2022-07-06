using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerN_2
{
    class Test
    {
        private int numModelos;
        private int numPreguntas;
        private String respuestas;

        public Test(int numModelos, int numPreguntas, String respuestas)
        {
            this.numModelos = numModelos;
            this.numPreguntas = numPreguntas;
            this.respuestas = respuestas;

        }

        public int corrigeModelo(int numeroModelo, string respuestas)
        {
            int puntajeTotal;

            if (numeroModelo == 1)
            {
                Console.WriteLine("TestModulo1");
                //declarar respuestas correctas
                //string respuestasBuenas = this.respuestas;
                string respuestasBuenas = "ABBDCA";
                //pasar las repuestas del alumno a mayusculas
                string respuestasMayus = respuestas.ToUpper();

                //pasar a array ambas respuestas
                char[] respuestaBuenaArr = respuestasBuenas.ToCharArray();
                char[] respuestaMayusArr = respuestasMayus.ToCharArray();

                int contadorbuenas = 0;
                int contadormala = 0;

                for (int i = 0; i < respuestaBuenaArr.Length; i++)
                {
                    if (respuestaBuenaArr[i] == respuestaMayusArr[i])
                    {
                        contadorbuenas++;
                        Console.WriteLine("Es buena");
                    }
                    else if (respuestaMayusArr[i] == ' ')
                    {
                       Console.WriteLine("Respuesta Nula");
                    }
                    else
                    {
                        contadormala++;
                        Console.WriteLine("Es mala");
                    }
                }

                return puntajeTotal = (contadorbuenas*3) - contadormala;
            }
           else if (numeroModelo == 2)
            {
                Console.WriteLine("TestModulo2");
                //declarar respuestas correctas
                string respuestasBuenas = "AAABBC";
                //pasar las repuestas del alumno a mayusculas
                string respuestasMayus = respuestas.ToUpper();

                //pasar a array ambas respuestas
                char[] respuestaBuenaArr = respuestasBuenas.ToCharArray();
                char[] respuestaMayusArr = respuestasMayus.ToCharArray();

                int contadorbuenas = 0;
                int contadormala = 0;

                for (int i = 0; i < respuestaBuenaArr.Length; i++)
                {
                    if (respuestaBuenaArr[i] == respuestaMayusArr[i])
                    {
                        contadorbuenas++;
                        //Console.WriteLine("Es buena");
                    }
                    else if (respuestaMayusArr[i] == ' ')
                    {
                        // Console.WriteLine("Respuesta Nula");
                    }
                    else
                    {
                        contadormala++;
                        //Console.WriteLine("Es mala");
                    }
                }

                return puntajeTotal = (contadorbuenas * 3) - contadormala;

            }
            else if (numeroModelo == 3)
            {
                Console.WriteLine("TestModulo3");
                //declarar respuestas correctas
                string respuestasBuenas = "ABCDAB";
                //pasar las repuestas del alumno a mayusculas
                string respuestasMayus = respuestas.ToUpper();

                //pasar a array ambas respuestas
                char[] respuestaBuenaArr = respuestasBuenas.ToCharArray();
                char[] respuestaMayusArr = respuestasMayus.ToCharArray();

                int contadorbuenas = 0;
                int contadormala = 0;

                for (int i = 0; i < respuestaBuenaArr.Length; i++)
                {
                    if (respuestaBuenaArr[i] == respuestaMayusArr[i])
                    {
                        contadorbuenas++;
                        //Console.WriteLine("Es buena");
                    }
                    else if (respuestaMayusArr[i] == ' ')
                    {
                        // Console.WriteLine("Respuesta Nula");
                    }
                    else
                    {
                        contadormala++;
                        //Console.WriteLine("Es mala");
                    }
                }

                return puntajeTotal = (contadorbuenas * 3) - contadormala;

            }
           
           
            return numeroModelo;
        }

        public int corrigeModeloAuto(int modelo,string respuestas ) 
        {
            int puntajeTotal = 0;

            Console.WriteLine("TestModulo1");
            //declarar respuestas correctas
            //string respuestasBuenas = this.respuestas;
            string respuestasBuenas = this.respuestas;
            //pasar las repuestas del alumno a mayusculas
            string respuestasMayus = respuestas.ToUpper();

            //pasar a array ambas respuestas
            char[] respuestaBuenaArr = respuestasBuenas.ToCharArray();
            char[] respuestaMayusArr = respuestasMayus.ToCharArray();

            int contadorbuenas = 0;
            int contadormala = 0;

            for (int i = 0; i < respuestaBuenaArr.Length; i++)
            {
                if (respuestaBuenaArr[i] == respuestaMayusArr[i])
                {
                    contadorbuenas++;
                    Console.WriteLine("Es buena");
                }
                else if (respuestaMayusArr[i] == ' ')
                {
                    Console.WriteLine("Respuesta Nula");
                }
                else
                {
                    contadormala++;
                    Console.WriteLine("Es mala");
                }
            }

            return puntajeTotal = (contadorbuenas * 3) - contadormala;

        }


    }
}
