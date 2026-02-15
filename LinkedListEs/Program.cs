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
            lista.AddToAPosition(15,2);
            lista.Display();
            lista.AddToAPosition(15,7);
            lista.Display();
        }
    }
}
