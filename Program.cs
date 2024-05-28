using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "232423", modelo: "modelo", imei: "imei", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "231321", modelo: "modelo 2", imei: "imei", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Zoom");
