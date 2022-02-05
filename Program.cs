using AprendendoGit;

Console.WriteLine("==========================================================");
Console.WriteLine("                      Hello, World!");
Console.WriteLine("==========================================================");

var reg1 = new Registro()
{
    Id = 1,
    DataNascimento = new DateTime(1982, 2, 28),
    Nome = "Eberton Sobreira"
};

Console.WriteLine($"ID: {reg1.Id}, {reg1.Nome}, {reg1.DataNascimento.ToShortDateString()}");