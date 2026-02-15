namespace LinkedListEs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomNode lista = new CustomNode();
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                lista.AddLast(r.Next(0,11));
            }
            lista.Display();
            Console.WriteLine("aggiungi numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("aggiungi posizione");
            int posizione = int.Parse(Console.ReadLine());
            lista.AddToAPosition(numero,posizione);
            lista.DisplayNumeriPari();
            lista.DisplayNumeriDispari();
        }
    }
}
