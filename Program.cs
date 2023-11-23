namespace EstudiarExamenListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.InsertarInicio(20);
            lista.InsertarInicio(5);
            lista.InsertarInicio(2);

            lista.ImprimirLista();

        }
    }
}