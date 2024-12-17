using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Testando Nokia");

        Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3220", imei: "111111111", memoria: 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("Testando iPhone");

        Smartphone iphone = new Iphone(numero: "654321", modelo: "iPhone 14", imei: "222222222", memoria: 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
