Console.Write("Enter a number that indicates the day of the week (1 for Monday, 2 for Tuesday, 3 for Wednesday, 4 for Thursday, 5 for Friday, 6 for Saturday, 7 for Sunday): ");
string number = Console.ReadLine();
int number1 = Int32.Parse(number);
if(number1 > 5 & number1 < 8)
{
    Console.WriteLine("It's a day off");
}
else
{
    Console.WriteLine("It's not a day off");
} 