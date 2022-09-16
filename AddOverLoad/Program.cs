// See https://aka.ms/new-console-template for more information
using AddOverload;

while (true)
{
    bool cont = true;
    
    Console.WriteLine("\nSelect a function:\nSelect \"1\" for adding two integers" +
                      "\nSelect \"2\" for adding two decimals\n" +
                      "Select \"3\" for adding two decimals that may or may not be money");

    while (cont == true)
    {
        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                Class1.Case1();
                cont = false;
                break;
            case "2":
                Class1.Case2();
                cont = false;
                break;
            case "3":
                Class1.Case3();
                cont = false;
                break;
            default:
                Console.WriteLine("Invalid selection");
                cont = true;
                break;
        }
    }
    Console.Write("Do you want to continue? Yes/no: ");
    if (Console.ReadLine().ToLower() == "yes") continue;
    else break;
}