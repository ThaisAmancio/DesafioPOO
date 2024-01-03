using DesafioPOO.Models;

Console.WriteLine("iPhone:");

Smartphone iphone = new Iphone(numero: "78695", modelo: "iphone12", imei: "10101010", memoria: 128);

iphone.LigarAparelho();
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("WhatsApp");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Teams");
iphone.DesligarAparelho();

Console.WriteLine("\n");

Console.WriteLine("Nokia:");

Smartphone nokia = new Nokia(numero: "4545262", modelo: "tijoloQuebraTesta", imei: "2222222", memoria: 64);
nokia.LigarAparelho();
nokia.Ligar("Thais");
nokia.InstalarAplicativo("Instagram");
nokia.InstalarAplicativo("Discord");
iphone.ReceberLigacao();
nokia.InstalarAplicativo("Destiny Companion");
nokia.DesligarAparelho();