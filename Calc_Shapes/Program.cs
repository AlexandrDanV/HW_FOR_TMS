namespace Calc_Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool isCor = true;
                while (isCor)
                {
                    Console.Clear();
                    Console.WriteLine("Choose the shape name:");
                    Console.WriteLine($"{NameFigures.Rhomb} 1, {NameFigures.Square} 2," +
                        $"{NameFigures.Triangle} 3");
                    var isNum = int.TryParse(Console.ReadLine(), out var num);
                    var nameShape = "";
                    var areaShape = 0d;
                    if (isNum)
                    {
                        switch (num)
                        {
                            case 1:
                                areaShape = new Rhomb().CulcAreaShape();
                                nameShape = NameFigures.Rhomb.ToString();
                                break;
                            case 2:
                                areaShape = new Square().CulcAreaShape();
                                nameShape = NameFigures.Square.ToString();
                                break;
                            case 3:
                                areaShape = new Triangle().CulcAreaShape();
                                nameShape = NameFigures.Triangle.ToString();
                                break;
                            default:
                                Console.WriteLine("Ented the incorrect data!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Clarify the choce again!");
                        Console.WriteLine("Tap on the keyboard!");
                        Console.ReadLine();
                    }

                    if (areaShape != -1) { Console.WriteLine($"{nameShape} area is {areaShape}"); }
                    else { Console.WriteLine("You need to think more!"); }

                    Console.WriteLine("\nto continue, click - 0");
                    var isValid = int.TryParse(Console.ReadLine(), out int cl);
                    if (cl==0&isValid is true) { }
                    else { break; }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

           
        }
    }
}
