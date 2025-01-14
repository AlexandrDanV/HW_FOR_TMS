using static System.Console;
// See https://aka.ms/new-console-template for more information
#region Unknown 1
try
{
	try
	{
		throw new Exception("0"); // 1. кидаем 0
		Write(1);
		throw new Exception("2");
	}
	catch (Exception a) // 2 catch "0"  
	{
		Write(3); // console "3"
		throw new Exception (a.Message); // throw "0"
		Write(a.Message);	
	}
	finally { Write(4); } // console 4
	Write(5);	
}
catch (Exception b) //catch "0"
{
	try
	{ throw new Exception("6"); } // throw "6"

	catch (Exception c)   // catch "6"
	{
		Write(c.Message); // console "6"
	}
	finally { Write(b.Message); };// console "0"
}
#endregion



