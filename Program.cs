using DesafioPOO.Models;



Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero: "(11) 9 8183-4664", modelo: "Nokia-A4", imei: "696969", memoria: 120);
nokia.Ligar();
nokia.InstalarAplicativo("Aplicativo Dio.me");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");

Smartphone iphone = new Iphone(numero: "(11) 9 8183-4664", modelo: "Iphone-S7", imei: "90909898", memoria: 300);
iphone.Ligar();
iphone.InstalarAplicativo("Aplicativo Dio.me");
