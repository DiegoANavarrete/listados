using System;
using System.Collections.Generic;
using System.Text;

namespace lista
{
    class main
    {//se ingresa los nodos para luego mostrar el resultado de la factura 
        static void Main(string[] args)
        {
            listaproductos l = new listaproductos();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            Console.WriteLine("\nLas facturas ingresadas son: ");
            l.desplegarlista();
            Console.ReadLine();
        }
    }
}
