System.Console.WriteLine("Ikkita butun son kiriting: ");
System.Console.Write("birinchi son: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("ikkinchi son: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber >0 && secondnumber>0)
{
    System.Console.WriteLine("Kiritilgan ikkala son ham musbat");
}
else
if(firstnumber<0 && secondnumber<0)
{
    System.Console.WriteLine("Ikkala son ham manfiy");
}
else
if(firstnumber==0 ||secondnumber==0)
{
    System.Console.WriteLine("ikkalasidan biri nolga teng ");
}
else
if(firstnumber==0 && secondnumber==0)
{
    System.Console.WriteLine("ikkala son ham nolga teng");
}
else
{
    System.Console.WriteLine("kiritilgan sonlarning biri manfiy ikkinchisi musbat ");
}
Console.ReadKey();

// System.Console.WriteLine("Iltimosh ismingizni kiriting: ");
// string UserName = Console.ReadLine();                
// System.Console.WriteLine($" {UserName} tashakkur ");
