string input = "29535123p48723487597645723645";
//string input = "29535123p48";
long sum = 0;

for (int i = 0; i < input.Length; i++)
{
    for (int j = i + 1; j < input.Length; j++)
    {
        if (Char.IsDigit(input[i]))
        {
            
            if (input[i] == input[j])
            {
                Console.Write(input.Substring(0, i));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(input.Substring(i, j - i + 1));
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(input.Substring(j + 1));
                sum += Convert.ToInt64(input.Substring(i, j - i + 1));
                break;
            }
            else if (Char.IsLetter(input[j]))
            {
                break;
            }
        }
    }

}

Console.WriteLine($"\nSumman är {sum}");
