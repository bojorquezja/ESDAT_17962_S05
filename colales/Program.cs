using colales;

ColaLES c = new ColaLES();
c.Enqueue("Hola");
c.Enqueue("mi");
c.Enqueue("amigo");
c.Dequeue();
//Console.WriteLine(c.GetValor(1));
Console.WriteLine(c.ToString());
