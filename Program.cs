using DesafioPOO.Models;


Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "11999999999", modelo: "Iphone XV", imei: "246515646651", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12999999999", modelo: "Nokia 16", imei: "123875316358", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
