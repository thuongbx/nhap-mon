// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Nhap nam sinh: ");
var namSinh = Console.ReadLine();
var namSinhSo = Int32.Parse(namSinh);

Console.WriteLine("Tuoi cua ban la " + (2022 - namSinhSo));
