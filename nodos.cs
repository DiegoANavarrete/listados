using System;


namespace lista
{
    class nodos
        //se ingresa la clase nodo entero para estrucutar los datos que ingresaremos
    {
        private int dato;
        private nodos siguiente;
        //ingresamos dato y siguiente para crear la estuctura del nodo
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public nodos Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
