using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiarExamenListas
{
    public class Lista
    {
        //CAPOS QUE VA A TENER LA CLASE
        private Nodo primerNodo;
        private Nodo ultimoNodo;

        //INICIALIZANDO EL PRIMERNODO EN VACIO
        //PARA QUE SEA VACIO
        public Lista()
        {
            primerNodo = null;
        }

        //METODO PARA SABER SI ESTA VACIO LA LISTA
        public bool vacio()
        {
            //SI EL PRIMER DATO ESTA VACIO
            if (primerNodo== null)
            {
                return true;

            }
            return false;
        }

        //METODO PARA INSERTAR AL FRENTE
        public void InsertarInicio(int elemento)
        {
            Nodo nuevoNodo = new Nodo(elemento);

            if (vacio())
            {
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                nuevoNodo.Siguiente = primerNodo;
                primerNodo = nuevoNodo;
            }
        }

        //METODO PARA IMPRIMIR
        public void ImprimirLista()
        {
            Nodo actual = primerNodo;

            while (actual != null)
            {
                Console.WriteLine(actual.Valor);
                actual = actual.Siguiente;
            }
        }


    }
}
