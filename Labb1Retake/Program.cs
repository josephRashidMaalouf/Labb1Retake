Console.WriteLine("skriv nummer o sånt");
string input = Console.ReadLine();
long sum = 0; // Räknar ihop summan av alla matchade tal
string firstPart = string.Empty; //Denna del skrivs alltid ut i vitt.

for (int i = 0; i < input.Length; i++)
{
    int counter = 0; //Håller koll på hur många gånger input[i] hittas i input[j]. Ska hittas två gånger.
    string potentialMatch = string.Empty; //tal som uppfyller vilkoret för uppgiften lagras här.
  
    firstPart += input[i]; //uppdaterar första(vita) delen av strängen)

    string lastPart = string.Empty; //nollställer den sista delen av strängen, som också skrivs ut i vitt

    for (int j = i; j < input.Length; j++)
    {

        if (!char.IsDigit(input[j]))
        {
            break;
        }
        

        if (input[i] == input[j])
        {
            counter++;
        }

        potentialMatch += input[j];

        if (counter == 2) //när räknaren har räknat till två utan avbrott har ett giltigt tal hittats.
        {
            for (int k = j +1; k < input.Length; k++) //allt som kommer efter matchen är slutet på strängen.
            {
                lastPart += input[k].ToString();
            }

            firstPart = firstPart.Remove(i); //ta bort det sista tecknet av firstpart så det inte blir en dublett mot det första tecknet av det giltiga talet.
            sum += long.Parse(potentialMatch); //addera värdet

            Console.Write(firstPart);           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(potentialMatch);
            Console.ResetColor();
            Console.Write(lastPart);

            firstPart += input[i]; //lägg tillbaks det sista tecknet som togs bort innan utskriften.
            Console.WriteLine();
            break;
        }

    }

}
Console.WriteLine("---");
Console.WriteLine($"Sum of all the numbers: {sum}");