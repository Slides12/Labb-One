// Variant 1  UTAN FUNKTIONER (Finns en variant 2 nedan med Funktioner)


// User interaction 
Console.WriteLine("Skriv en valfri sträng: ");
string userInput = Console.ReadLine();
Console.WriteLine();



// Variabler
bool isMoreThenOneCharacter = false;
string tempString = "";
long totalSum = 0;




for (int i = 0; i < userInput.Length; i++)
{
    for (int j = 0; j < userInput.Length; j++)
    {
        for (int k = 0; k < userInput.Length; k++)
        {

            if (k >= i && k <= userInput.IndexOf(userInput[i], i + 1))          // k>= i börja på userInput[i] om k är mindre OCH index userInput[i] (bokstaven på denna plats) efter index i +1, dvs kolla inte med userInput[i] utan nästa bokstav i ledet.
            {
                tempString += string.Join("", userInput[k]);                    // Bygg en temporär string med värdena som är mellan första och nästakommande värde

                if (tempString.All(char.IsDigit))                               //Om alla värden i tempString är siffror, så är stringen giltlig.
                {
                    isMoreThenOneCharacter = true;

                }
                else
                {
                    isMoreThenOneCharacter = false;
                }
            }

        }
        if (tempString.All(char.IsDigit) && long.TryParse(tempString, out long x) && j == userInput.Length - 1)  //Att kolla tempString.All och TryParse är kanske lite overkill, men får iaf en dubbel kontroll så att stringen är ett tal. Sen om j matchar längden, summera.
        {
            totalSum += x;
        }
        tempString = ""; //Resetta tempstringen

        if (isMoreThenOneCharacter)
        {
            if (j >= i && j <= userInput.IndexOf(userInput[i], i + 1) && char.IsDigit(userInput[i]))        //Kolla så att det är inom rätt range på index samt så att det är siffra, ej bokstav
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write(userInput[j]);
        }
    }
    if (isMoreThenOneCharacter)
    {
        Console.WriteLine();
    }

    if (i == userInput.Length - 1)
    {
        Console.WriteLine($"\nTotal: {totalSum}");
    }



    isMoreThenOneCharacter = false; //Resetta bool samt färg för nästa i++
    Console.ForegroundColor = ConsoleColor.White;

}







// Variant 2  MED FUNKTIONER


// User interaction
Console.WriteLine("Skriv en valfri sträng: ");
 string userInput2 = Console.ReadLine();
Console.WriteLine();

CheckAndColorString(userInput2);






static void CheckAndColorString(string userInput)
{
    long totalSum = 0;

    for (int i = 0; i < userInput.Length; i++)
    {

        totalSum += BuildASubstringAndReturnIfConditionMatch(userInput,i);

    }


    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine($"\nTotal: {totalSum}");
}



static long BuildASubstringAndReturnIfConditionMatch(string userInput, int index)
{
    string tempString = string.Empty;
    if (ContainsMoreThenOneCharacter(userInput, index))
    {
        for (int i = 0;i < userInput.Length; i++) { 
                
            if(i >= index && i <= userInput.IndexOf(userInput[index], index + 1)) {  
            tempString += string.Join("", userInput[i]);
                

            }

        }
        if (tempString.All(char.IsDigit) && tempString != "")
        {
            PrintAndColor(userInput, index);
            long totalSum = long.Parse(tempString);
            return totalSum;
        }
    }
            return 0;

}

static bool ContainsMoreThenOneCharacter(string userInput, int startindex)
{

    for(int i = 1;i < userInput.Length;i++)
    {
        if (userInput[startindex] == userInput[i])
        {
            return true;
        }
    }


    return false;
}



static int GetMaxIndexOfSecondChar(string userInput,int index)
{
    int maxIndex = userInput.IndexOf(userInput[index], index + 1);

    return maxIndex;
}


static void PrintAndColor(string userInput, int index)
{

    


    for (int i = 0; i < userInput.Length;i++)
    {
        if(i >= index && i < GetMaxIndexOfSecondChar(userInput, index) + 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(userInput[i]);

        }
        else 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(userInput[i]);


        }
        }
    Console.WriteLine();
}




