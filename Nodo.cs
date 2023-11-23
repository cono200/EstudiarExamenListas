using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiarExamenListas
{
    public  class Nodo
    {
        private int _valor; //VARIABLE DONDE SE ALMACENA LOS VALORES DE LA LISTA
        private Nodo? _siguiente; //ESTE APUNTA AL SIGUIENTE "NODO" DE LA LISTA

        //CONTRUCTOR QUE INICIALIZA EL NODO, EL CUAL SE PONE UN VALOR Y
        //UNA REFERENCIA VACIA
        public Nodo(int Valor)
        {
            _valor = Valor;
            _siguiente = null;
        }

        //HACIENDO QUE "VALOR" QUE ES DONDE SE GUARDA TODO
        //PUBLICO PARA PODER MODIFICAR SIN TENER QUE ACCEDER AL ORIGINAL
        public int Valor
        {
            get { return _valor;}
            set { _valor = value; }
        }
        // Constructor que inicializa un Nodo con un valor dado y una referencia al siguiente Nodo
        public Nodo(int Valor, Nodo Siguiente)
        {
            _valor = Valor;
            _siguiente = Siguiente;
        }
        //PROPIEDAD QUE SE USA PARA ACCEDER Y PARA MODIFICAR LAS REFERENCIAS
        //DEL SIGUIENTE NODO
        public Nodo Siguiente
        {
            get { return _siguiente;}
            set { _siguiente = value; }
        }
       

    }
}
