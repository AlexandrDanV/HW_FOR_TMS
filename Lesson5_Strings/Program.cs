namespace Lesson5_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\MyFolder\c#\TeachMeSkeals\05. String\Book2.txt";
                string strH_P = File.ReadAllText(path);

                Console.WriteLine(strH_P);
                Console.WriteLine(new string('*', 50));
                //Найти слова, содержащие максимальное количество цифр:           
                Console.WriteLine($"Слово с макс кол.цифр: {MyStringClass.GetMaxNumDigits(strH_P)}");
                Console.WriteLine(new string('*', 50));
                //- Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.
                string longestWord = MyStringClass.GetLongestWord(strH_P);
                Console.WriteLine($"Самое длинное слово: {longestWord}");
                Console.WriteLine($"Слово {longestWord} встретилось " +
                    $"в тексте {MyStringClass.GetNumMeetsWord(strH_P, longestWord)} раза!");
                Console.WriteLine(new string('*', 50));
                // -Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».
                Console.WriteLine($"Все цифры заменены на слова:\n" +
                    $"{MyStringClass.ChangeDigitWithWord(strH_P)}");
                Console.WriteLine(new string('*', 50));
                // -Вывести на экран сначала вопросительные, а затем восклицательные предложения.
                Console.WriteLine("Вопросительные предложения: ");
                var str = MyStringClass.ShowQuestionSentences(strH_P);
                foreach (var item in str)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(new string('*', 50));
                Console.WriteLine("Восклицательные предложения: ");
                str = MyStringClass.ShowPositSentence(strH_P);
                foreach (var item in str)
                {
                    Console.WriteLine(item);
                }
                // - Вывести на экран только предложения, не содержащие запятых.
                Console.WriteLine(new string('*', 50));
                Console.WriteLine("Предложения, не содержащие запятых:");
                str = MyStringClass.ShowSentencesWithoutCommas(strH_P);
                foreach (var item in str)
                {
                    Console.WriteLine(item);
                }
                // -Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.
                Console.WriteLine(new string('*', 50));
                Console.WriteLine("Слова начинающиеся и заканчивающиеся на одну и ту же букву: ");
                str = MyStringClass.GetWordsWithTheSameLetters(strH_P);
                foreach (var item in str)
                {
                    Console.WriteLine(item);
                }

            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Указан недопустимый путь!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Передан null, однако функция" +
                    " не принимает его в качестве допустимого аргумента!");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"{ex.Message}, {ex.Data}");
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine($"{ex.Message}, Где-то присутствует бесконечный цикл");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
