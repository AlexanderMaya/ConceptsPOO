using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

try
{
    Console.WriteLine(new Date(2023, 02, 28));
    Console.WriteLine(new Date(1983, 03, 21));
    Console.WriteLine(new Date(1733, 11, 39));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}

