
string input = "29535123p48723487597645723645";

input = "2552465262234";
long sum = 0;

Console.WriteLine($"Skriv en en rad med siffror och tecken.");
//input = Console.ReadLine();

Console.WriteLine(input);
Console.WriteLine();

for (int i = 0; i < input.Length; i++)
{
    bool nextTo = true;
    for (int j = i + 1; j < input.Length; j++)
    {
        if (Char.IsDigit(input[j]))
        {
            if (nextTo)
            {
                if (input[i] == input[j])
                {
                    break;
                }
                else
                {
                    nextTo = false;
                }
            }
            if (input[i] == input[j])
            {
                Console.Write(input.Substring(0, i));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(input.Substring(i, j - i + 1));
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(input.Substring(j + 1));
                Console.WriteLine();
                sum += Convert.ToInt64(input.Substring(i, j - i + 1));
                break;
            }
        }
        else
        {
            break;
        }
    }
}

Console.WriteLine();
Console.WriteLine($"Summan av dom markerade talen är {sum}");