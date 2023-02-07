// Escribe un programa que reciba tu nombre y lo escriba por consola.

Console.WriteLine("¿Como te llamas?");
string name = Console.ReadLine();
Console.WriteLine("Hola " + name);


// Escribe un programa que tome la hora y la escriba por pantalla.

string datetime = DateTime.Now.ToString("hh:mm:ss tt");
Console.WriteLine(datetime);