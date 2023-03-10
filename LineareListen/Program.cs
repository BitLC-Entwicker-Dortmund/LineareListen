namespace LineareListen {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Liste!");

            Knoten first = new Knoten(10, null);
            Knoten newK = new Knoten(12, null);
            Knoten akt = first;
            akt.SetNext(newK);
            newK = new Knoten(13, null);
            akt = first;
            akt = akt.GetNext();
            akt.SetNext(newK);

            // Anzeigen

            akt = first;
            //Console.WriteLine(  akt.GetInfo());
            //akt = akt.GetNext();
            //Console.WriteLine(akt.GetInfo());
            //akt = akt.GetNext();
            //Console.WriteLine(akt.GetInfo());

            while (akt.GetNext() != null) {
                Console.WriteLine(akt.GetInfo());
                akt = akt.GetNext();
                if (akt.GetNext() == null) {
                    Console.WriteLine(akt.GetInfo());
                }
            }

            LineareListe ll = new LineareListe();
            ll.Add("Mohamad");
            ll.Add(123);
            ll.RemoveFirst();

            Console.Read();
        }
    }
}