using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("1199999999", "Nokia 3310", "123456789", 64);
        Smartphone iphone = new Iphone("1188888888", "iPhone 14", "987654321", 128);

        Console.WriteLine("Testando Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTestando iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
