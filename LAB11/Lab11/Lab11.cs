using Lab10;
namespace Lab11;

public static class Lab11
{
    public static void Main()
    {
        //Тест на своих классах
        Reflector.GetNameOfTheAssembly("Lab11.Computer, Lab11");
        Reflector.WriteAllFieldsAndProperties("Lab11.Computer, Lab11");
        Reflector.WriteAllInterfaces("Lab11.Computer, Lab11");
        Reflector.WriteAllClassMethodsWithParameter("Lab11.Computer, Lab11", "amount");
        Reflector.Invoke("Lab11.Computer, Lab11", "MountingVideocard");
        
        Reflector.IsTherePublicConstructor("Lab10.Flat, Lab11");
        Reflector.WritePublicMethods("Lab10.Flat, Lab11");
        Reflector.WriteAllFieldsAndProperties("Lab10.Flat, Lab11");
        Reflector.GetNameOfTheAssembly("Lab10.Flat, Lab11");
        
        //Тест на стандартных классах .NET
        Reflector.GetNameOfTheAssembly("System.String");
        Reflector.IsTherePublicConstructor("System.String");
        Reflector.WritePublicMethods("System.String");

        //2 задание
        var flat = Reflector.Create("Lab10.Flat");
        if (flat is Flat)
        {
            Console.WriteLine("\nЭто объект типа Flat.");
        }
        else
        {
            Console.WriteLine("\nЭтот объект не типа Flat.");
        }
    }
}