// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Mmel and xavier's Guessing game!");
int puppies = 8;
Console.WriteLine("Please guess a number bettween 1-10.");
string input = Console.ReadLine();
int inputNum = Convert.ToInt32(input);
if(inputNum == puppies)
{
    Console.WriteLine("Number is correct");
}
else if (inputNum > 10 || inputNum < 1)
{
    Console.WriteLine("User must use only 1-10");
}
else
{
    Console.WriteLine("number is not correct. Try Again!");
}

//guessing game
Console.WriteLine("Please guess a random number.");
string inputR = Console.ReadLine();
int inVal = Convert.ToInt32(inputR);
int right = 12;
if (inVal > right || inVal < right)
{
    Console.WriteLine(inVal - right + " is the difference from the correct answer.");
    Console.WriteLine("Please guess a random number.");
    string inputR2 = Console.ReadLine(); 
    inVal = Convert.ToInt32(inputR2);
    if (inVal == right)
    {
        Console.WriteLine("You have choosen the right answer");
    }
    else
    {
        Console.WriteLine(inVal - right + " is the difference from the correct answer.");
        Console.WriteLine("Please guess a random number.");
        string inputR3 = Console.ReadLine();
        inVal = Convert.ToInt32(inputR3);
    }

}
else
{
    Console.WriteLine("You have choosen the right answer");
}

//random number gen
Console.WriteLine("Please guess a random number.");
string inputRD = Console.ReadLine();
int inValR = Convert.ToInt32(inputR);
int rightR = 12;
if (inValR > rightR || inValR < rightR)
{
    Random inValN = new Random();
    for (int i = 0; i < 4; i++)
    {
        inValN.Next(10);
    }
    int inValNumR = Convert.ToInt32(inValN);
    Console.WriteLine(inValNumR - rightR + " is the difference from the correct answer.");
    Console.WriteLine("Please guess a random number.");
    string inputRD2 = Console.ReadLine();
    inValR = Convert.ToInt32(inputRD2);
    if (inValR == rightR)
    {
        Console.WriteLine("You have choosen the right answer");
    }
    else
    {
        Console.WriteLine(inValNumR - rightR + " is the difference from the correct answer.");
        Console.WriteLine("Please guess a random number.");
        string inputRD3 = Console.ReadLine();
        inValR = Convert.ToInt32(inputRD3);
    }

}
else
{
    Console.WriteLine("You have choosen the right answer");
}