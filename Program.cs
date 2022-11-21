Console.WriteLine("number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999 || number < 100)
{
    Console.WriteLine("число не трехзначное");
}
else
{
int sum = (number / 10) - (number / 100) * 10 ;
Console.WriteLine(sum);
}