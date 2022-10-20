// See https://aka.ms/new-console-template for more information
string nombre, apellido;
int edad;
bool sabeProgramar;

Console.WriteLine("Nombre: ");
nombre = Console.ReadLine();

Console.WriteLine("Apellido: ");
apellido = Console.ReadLine();

Console.WriteLine("Edad: ");
edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sabes Programar? Indica True o False: ");
sabeProgramar = Convert.ToBoolean(Console.ReadLine());


if (sabeProgramar == true)
{
    Console.WriteLine("Te llamas " + nombre + " " + apellido + " tienes " + edad + " años y " + " sabes programar");
}
if (sabeProgramar == false)

{ Console.WriteLine("Te llamas " + nombre + " " + apellido + " tienes " + edad + " años y " + " no sabes programar"); }
