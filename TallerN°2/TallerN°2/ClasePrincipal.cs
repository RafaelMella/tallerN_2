using System;
using System.Collections;

namespace TallerN_2
{
    class ClasePrincipal
    {
       static void Main(string[] args) 
        {
            Test test1 = new Test(1,6,"ABBDCA");
            Alumno alumno1 = new Alumno("Rafael",1,"ABB CB");

            Test test2 = new Test(2,6,"AAABBC");
            Alumno alumno2 = new Alumno("Vicente", 2, "AAABBC");

            Test test3 = new Test(3,6,"ABCDAB");

            /* //Instancio el SimTest
             SimTest simTest1 = new SimTest(1,6,"ABBDCA");

             //PRUEBA DE METODO CORRIGEMODELO DE LA CLASE TEST
             Console.WriteLine("Primera prueba");
             int numRespuesta;
             numRespuesta = test1.corrigeModelo(alumno1.NumeroDeModeloRealizado, alumno1.RespuestaAlumno);
             Console.WriteLine("la cantidad de repsuestas correctas son: {0}",numRespuesta);

             //PRUEBA DE METODO CORRIGE DE LA CLASE ALUMNO
             Console.WriteLine("Segunda prueba");
             int numRespuesta2;
             numRespuesta2 = alumno2.corrige(test2);
             Console.WriteLine("la cantidad de repsuestas correctas son: {0}", numRespuesta2);
            */
            //PRUEBA DE RESPUESTAS ALUMNO ALEATORIAS, MODELOS ALEATORIOS Y RESPUESTA TEST ALEATORIAS
            string nombreAlumno = nombreAleatorioAlumno();
            int modeloAleatorioAlumno = new Random().Next(0, 4);
            Console.WriteLine("El modelo es: {0}",modeloAleatorioAlumno);
            string respuestasTest = respuestaAleatoriaTest();
            Test test4 = new Test(4, 6, respuestasTest);
            string respuestasAlumno = respuestaAleatoriaAlumno();
            Alumno alumno3 = new Alumno(nombreAlumno, modeloAleatorioAlumno, respuestasAlumno);
            int resultadoTest = alumno3.corrige(test1);
            Console.WriteLine("El alumno saco {0}", resultadoTest);

        }

        static String respuestaAleatoriaAlumno() 
        {
            var chars = "ABCD ";
            var respuestas = new char[6];
            var random = new Random();

            for (int i = 0; i < respuestas.Length; i++)
            {
                respuestas[i] = chars[random.Next(chars.Length)];
            }

            var respuestasFinal = new String(respuestas);

            Console.WriteLine("Las respuestas del alumno son:->{0}",respuestasFinal);

            return respuestasFinal;
            
        }

        static String respuestaAleatoriaTest()
        {
            var chars = "ABCD";
            var respuestas = new char[6];
            var random = new Random();

            for (int i = 0; i < respuestas.Length; i++)
            {
                respuestas[i] = chars[random.Next(chars.Length)];
            }

            var respuestasFinal = new String(respuestas);

            Console.WriteLine("Las respuestas del test son:->{0}", respuestasFinal);

            return respuestasFinal;


        }

        static String nombreAleatorioAlumno() 
        {
            int numeroAleatorio = new Random().Next(0, 6);
            Console.WriteLine("Numero para el nombre es: {0}", numeroAleatorio);
            String[] nombres = { "Pablo","Rafael","Vicente","Luis","Jorge","Javiera" }; 
            string nombreDecidido = nombres.ElementAt(numeroAleatorio).ToString();

            Console.WriteLine("El nombre del alumno es: {0}",nombreDecidido);

            return nombreDecidido;
        }

     
    }
} 




