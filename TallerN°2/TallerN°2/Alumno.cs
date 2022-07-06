using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerN_2
{
    class Alumno
    {
        private string nombreAlumno;
        private int numeroDeModeloRealizado;
        private string respuestaAlumno;


        public Alumno(string nombreAlumno, int numeroDeModeloRealizado, string respuestaAlumno)
        {
            this.nombreAlumno = nombreAlumno;
            this.numeroDeModeloRealizado = numeroDeModeloRealizado;
            this.respuestaAlumno = respuestaAlumno;

        }
        public string NombreAlumno
        {
            get { return nombreAlumno; }



        }
        public int NumeroDeModeloRealizado
        {
            get { return numeroDeModeloRealizado; }
        }

        public string RespuestaAlumno
        {
            get { return respuestaAlumno; }
        }

        public int corrige(Test test) {

            int puntajeAlumno = test.corrigeModelo(this.numeroDeModeloRealizado, this.respuestaAlumno);
            
            return puntajeAlumno;
        }

        public int corrigeAuto(Test test)
        {

            int puntajeAlumno = test.corrigeModeloAuto(this.numeroDeModeloRealizado, this.respuestaAlumno);

            return puntajeAlumno;
        }
    }
}

