// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Enter your number to convert into a day of week: ");
string strDayofWeek = Console.ReadLine();
int DayofWeek = Convert.ToInt32(strDayofWeek);

Console.Write("Your number corresponds to: ");
if(DayofWeek == 1)
{
    Console.WriteLine("Mon");
}
if(DayofWeek == 2)
{
    Console.WriteLine("Tue");
}
if(DayofWeek == 3)
{
    Console.WriteLine("Wed");
}
if(DayofWeek == 4)
{
    Console.WriteLine("Thur");
}
if(DayofWeek == 5)
{
    Console.WriteLine("Fri");
}
if(DayofWeek == 6)
{
    Console.WriteLine("Sat");
}
if(DayofWeek == 7)
{
    Console.WriteLine("Sun");
}
if(DayofWeek<1 || DayofWeek > 7)
{
    Console.WriteLine("Your have entered a wrong number");
    return;
}

// switch(DayofWeek)
// {
//     case 1: Console.WriteLine("Mon"); break;
//     case 2: Console.WriteLine("Tue"); break;
//     case 3: Console.WriteLine("Wen"); break;
//     case 4: Console.WriteLine("Tue"); break;
//     case 5: Console.WriteLine("Fri"); break;
//     case 6: Console.WriteLine("Sat"); break;
//     case 7: Console.WriteLine("Sun"); break;
// default: Console.WriteLine("You have netered a wrong number"); break;
// }