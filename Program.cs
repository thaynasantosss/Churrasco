int AdultosAlcoólatras, AdultosNãoAlcoólatras, criancas, Adultos, TotalPessoas;
double carne, acompanhamentos, cerveja, refrigerante, agua;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("*** Churrasquinho ***\n");



Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Adultos (que são alcoólatras): ");
AdultosAlcoólatras = Convert.ToInt32(Console.ReadLine());


Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Adultos (que não são alcoólatras): "); 
AdultosNãoAlcoólatras = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Crianças: ");
criancas = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Adultos = AdultosAlcoólatras + AdultosNãoAlcoólatras;
TotalPessoas = Adultos + criancas;


carne = 0.8 * Adultos + 0.4 * criancas;
acompanhamentos = 0.2 * TotalPessoas;
cerveja = 2 * AdultosAlcoólatras;
refrigerante = 0.9 *  AdultosNãoAlcoólatras + criancas;
agua = 0.6 * TotalPessoas;


Console.WriteLine();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"Carne.............: {carne:N1}kg");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Acompanhamentos...: {acompanhamentos:N1}kg");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Cerveja...........: {cerveja:N1}l");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Refrigerante......: {refrigerante:N1}l");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Água..............: {agua:N1}l");

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Clique Em Qualquer Tecla Para Continuar...");
Console.ResetColor();

Console.ReadKey();

Console.Clear();