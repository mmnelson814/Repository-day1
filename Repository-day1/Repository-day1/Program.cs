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
