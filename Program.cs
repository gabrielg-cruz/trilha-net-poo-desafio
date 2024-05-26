using DesafioPOO.Models;

TesteNokia();
Console.WriteLine("");
TesteIphone();

void TesteNokia()
{
    Console.WriteLine("Nokia");
    Smartphone nokia = new Nokia(numero: "123", modelo: "abc", imei: "55555", memoria: 45);
    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("qwerty");
}

void TesteIphone()
{
    Console.WriteLine("Iphone");
    Smartphone iphone = new Iphone(numero: "321", modelo: "cba", imei: "77777", memoria: 4);
    iphone.Ligar();
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("ytrewq");
}
