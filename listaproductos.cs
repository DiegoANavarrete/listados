using System;
using System.Collections.Generic;
using System.Text;

namespace lista
{
    class listaproductos
        //declaramos apuntadores para la lista para el primero y ultimo
    {
        private nodos Primero = new nodos();
        private nodos Ultimo = new nodos();
        //declaramos constructor de la lista 
        public listaproductos()
        {
            Primero = null;
            Ultimo = null;

        }
        //creamos el nodo
        public void insertarnodo()
        {
            nodos nuevo = new nodos();
            Console.Write("Ingrese el numero de factura en la cual se ha realizado el pago: ");
            nuevo.Dato = int.Parse(Console.ReadLine());
            //creamos la lista e identificar el inicio de la lista y el ultimo e igualmente la confirmacion de la factura registrada
            if (Primero == null)
            {
                Primero = nuevo;
                Primero.Siguiente = null;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                Ultimo = nuevo;
            }
            Console.WriteLine("\nNumero de factura ingresada correctramente\n");

        }
        //se crea una segunda opcion en donde se muestre que una factura no se encuentra en la base de datos
        public void desplegarlista()
        {
            nodos actual = new nodos();
            actual = Primero;
            if (Primero != null)
            {
                while(actual != null)
                {
                    Console.WriteLine(" {0} ", actual.Dato);
                    actual = actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\nNo se encuentra una factura con este número\n");
            }
        }
    }
}
