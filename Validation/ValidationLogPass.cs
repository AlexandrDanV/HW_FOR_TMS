using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation.InvalidExceptions;

namespace Validation
{

    public class ValidationLogPass
    {
        const int maxLengthLogin = 19;
        const int maxLengthPassword = 19;
        static char simbol = ' ';

        //// В методе использ.каскад, чтобы вернуть bool(как обязательное условие задачи) и 
        ///Exception терять не хочеться (stackTrace сохраняется)
         
        /// <summary>
        ///Метод возвращает true если каскад проверок пройден успешно. 
        ///Если выпадает исключение, то  срабатывает catch.   
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <returns></returns>
        public static (bool, Exception) ValidateLogPass(string login, string password, string confirmPassword)
        {

            try
            {
                if (CheckForNullOrEmpty(login, password, confirmPassword) is true)
                {
                    throw new NullReferenceException(message: "Null or empty!");
                }
                if (CheckLogin(login, maxLengthLogin, simbol) is false)
                {
                    throw new WronLoginException("Entered incorrect login.");
                }
                if (CheckPassword(password, maxLengthPassword, simbol) is false)
                {
                    throw new WronPasswordException("Entered password is incorrect.");
                }
                if (password != confirmPassword)
                {
                    throw new ComparePasswordExceptions("Entered passwords don't match.");
                }

                return (true, null);
            }

            catch (Exception ex)
            {
                return (false, ex); 
            }
        }

        static bool CheckForNullOrEmpty(string login, string password, string confirmPassword)
        {
            var isNullOrEmpty = (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(confirmPassword)) ? true : false;
            return isNullOrEmpty;
        }

        public static bool CheckLogin(string login, int maxLength, char simbol)
        {
            var isRelevant = (login.Length <= maxLength && !login.Contains(simbol)) ? true : false;
            return isRelevant;
        }
        public static bool CheckPassword(string pass, int maxLength, char simbol)
        {
            var isRelevant = (pass.Length <= maxLength && !pass.Contains(simbol)
                && ContainDigit(pass)) ? true : false;
            return isRelevant;
        }

        static bool ContainDigit(string param)
        {
            var chars = param.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsDigit(chars[i]))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
