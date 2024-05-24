

string[] Options = { "Scenario 1", "Scenario 2", "Scenario 3" };


string text = "";



foreach (string option in Options)
{
    
    text += option + "|";
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(text);
Console.ResetColor();

Console.Write("> (int) ");


string? curOption = Console.ReadLine();

int Id = curOption != null ? Convert.ToInt16(curOption) : 1;

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
