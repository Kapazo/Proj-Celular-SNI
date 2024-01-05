using DesafioPOO.Models;

Smartphone I = new Iphone(numero: "4987", modelo:"Modelo 2", imei: "2222222222", memoria: 128);
Smartphone N = new Nokia(numero: "123456", modelo:"Modelo 1", imei:"1111111111", memoria: 64);

Console.WriteLine("Smartphone Nokia:");
N.Ligar();
N.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
I.ReceberLigacao();
I.InstalarAplicativo("Telegram");
//caso o programa não rode, verifique se o repositorio certo está inserido
//utilize "cd trilha-net-poo-desafio"
