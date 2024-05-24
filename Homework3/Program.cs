string[] Options = { "Scenario 1 [1]", "Scenario 2 [2]", "Scenario 3 [3]" };
int Id = 1;

void Show()
{
    try
    {
        Console.Clear();
        string? curOption = null;
        string text = "";
        foreach (string option in Options)
        {
    
           text += option + " | ";
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("| " + text);
        Console.ResetColor();

        Console.Write("> (int) ");


        curOption = Console.ReadLine();
        int Id = curOption != null ? Convert.ToInt16(curOption) : 1;
    }
    catch (Exception)
    {
        Console.Clear();
        Console.WriteLine("Error!");
        Show();
    }
   

}


Show();


void Sc1()
{
	
    string txt = "Enter five marks";
    Console.WriteLine(txt);

    int MaxMarks = 5;
    int AllMarksSum = 0;

	for (int i = 0; i < 5; i++)
	{
        Console.Write("({0}) >", i+1);

        string? inp = Console.ReadLine();

        int mark = Convert.ToInt16(inp);
        mark = Math.Clamp(mark, 0, 12);

        AllMarksSum += mark;

    }

    int Average = AllMarksSum / MaxMarks;
    Console.WriteLine("Your average mark is > {0}",Average);
}

void Sc2()
{
    Console.WriteLine("Enter number");
    Console.Write("> ");
    string? inp = Console.ReadLine();

    try
    {
        float number = Convert.ToSingle(inp);
        float result = number % 2 == 0 ? number / 2 : number / 3;
        Console.WriteLine(result);
    }
    catch (Exception)
    {
        Console.WriteLine("Incorect number!");
        Sc2();
    }
}

void Sc3()
{

}

// scenario player

Action[] actions = { Sc1,Sc2,Sc3};

if (actions.Length >= Id - 1)
{
    actions[Id - 1].Invoke();
}
