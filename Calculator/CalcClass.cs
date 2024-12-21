using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    internal class CalcClass
    {
        string strPostfix = null;
        public CalcClass(string strInput)
        {
            this.strPostfix = GetExpression_PNotation(strInput);
        }

        int GetPriority(char simb)
        {
            int simbol = simb switch
            {
                '+' => 1,
                '-' => 1,
                '%' => 1,
                '*' => 2,
                '/' => 2,
            };
            return simbol;
        }
        double GetArith_Res(char simbol, double first, double second)
        {
            double res = simbol switch
            {
                '+' => first + second,
                '-' => first - second,
                '*' => first * second,
                '/' => first / second,
            };
            return res;
        }
        string GetExpression_PNotation(string strInput)
        {
            string strForSave = null;
            Stack<char> stack = new();

            for (int i = 0; i < strInput.Length; i++)
            {
                char c = strInput[i];
                if (Char.IsDigit(strInput[i]))
                {
                    strForSave += strInput[i];
                }
                
                else if (strInput[i] == 'p')
                {
                    string strOntime = null;

                    while (i < strInput.Length - 1)
                    {
                        if (Char.IsDigit(strInput[i]) || strInput[i] == 'p')
                        {
                            strOntime += strInput[i];
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    strForSave += strOntime;
                    i--;

                }
                if (Char.IsDigit(strInput[i]) is false)
                {
                    strForSave += " ";

                    while (stack.Count > 0 && (GetPriority(stack.Peek()) >= GetPriority(strInput[i])))
                        strForSave += stack.Pop();

                    stack.Push(strInput[i]);
                }
            }
            foreach (var item in stack)
            {
                strForSave += item;
            }
            return strForSave;
        }
        public double Calculater()
        {
            Stack<double> numsStack = new();
            string strNumber = null;
            for (int i = 0; i < strPostfix.Length; i++)
            {
                char c = strPostfix[i];
                if (strPostfix[i] == 'p')
                {
                    i++;
                    string strOntime = null;
                    while (true)
                    {
                        if (Char.IsDigit(strPostfix[i]))
                        {
                            strOntime += strPostfix[i];
                            i++;
                        }
                        else
                        {

                            var isNum = double.TryParse(strOntime, out double num);
                            num = num / 100;
                            numsStack.Push(num);
                            break;
                        }
                    }
                }
                if (Char.IsDigit(strPostfix[i]))
                {
                    while (true)
                    {
                        if (Char.IsDigit(strPostfix[i]) is true)
                        {
                            strNumber += strPostfix[i];
                            i++;
                        }
                        else
                        {
                            i--;
                            numsStack.Push(double.Parse(strNumber));
                            strNumber = null;
                            break;
                        }
                    }
                }

                else if (!Char.IsDigit(strPostfix[i]) && strPostfix[i] != ' ')
                {
                    double second = numsStack.Count > 0 ? numsStack.Pop() : 0;
                    double first = numsStack.Count > 0 ? numsStack.Pop() : 0;
                    numsStack.Push(GetArith_Res(strPostfix[i], first, second));
                }
            }
            return numsStack.Pop();
        }
    }
}
