Console.WriteLine("Skriv in önskad blandning av bokstäver och siffror att gå igenom");
string input = Console.ReadLine();

long sum = 0;

for (int i = 0; i < input.Length; i++)
{
    for (int j = i + 1; j < input.Length; j++)
    {
        if (Char.IsDigit(input[i]))                             //Kollar om tecken är en siffra
        {
            
            if (input[i] == input[j])                           //Går igenom det inskrivna och letar efter två lika
            {
                Console.Write(input.Substring(0, i));           //Skriver ut tecken innan det som markeras
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(input.Substring(i, j - i + 1));   //Skriver ut tecken som markeras
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(input.Substring(j + 1));      //Skriver ut tecken efter det som markeras
                sum += Convert.ToInt64(input.Substring(i, j - i + 1));
                break;
            }
            else if (Char.IsLetter(input[j]))                   //Kollar så att det endast är siffror som markeras
            {
                break;
            }
        }
    }

}

Console.WriteLine($"\nSumman är {sum}");
