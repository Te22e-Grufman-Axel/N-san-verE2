List<string> städer = new List<string>();
bool exit = false;
string answer;

while (exit == false)
{
    Console.WriteLine("Skriv in en stad:");
    answer = Console.ReadLine();
    answer.ToLower();
    if (answer == "exit") 
    {
        exit = true;
    }
    else
    {
        städer.Add(answer);
    }
}
Console.WriteLine();
Console.WriteLine("Städer du har skrivit");
for (int i = 0; i < städer.Count; i++)
{
    Console.WriteLine(städer[i]);
}

Console.ReadLine();