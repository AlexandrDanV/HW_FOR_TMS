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

        public static bool ValidateLogPass(string login, string password, string confirmPassword)
        {
            var isSuccessfulControll = false;
            try
            {
                if (CheckForNullOrEmpty(login, password, confirmPassword) is true)
                {
                    throw new InvalidParamsExceptions("Entered params are null or empty.");
                }

                var isValidLogin = (CheckLogin(login, maxLengthLogin, simbol)) ? true :
                    throw new WronLoginException("Entered incorrect login.");

                var isValidPassword = (CheckPassword(password, maxLengthPassword, simbol)) ? true :
                    throw new WronPasswordException("Entered password is incorrect.");

                var isCompare = (password == confirmPassword) ? true :
                    throw new ComparePasswordExceptions("Entered passwords don't match.");
                isSuccessfulControll = (isValidLogin && isValidPassword && isCompare) ? true : false;

                return isSuccessfulControll;
            }

            catch (Exception)
            {
                throw;
            }

        }

        static bool CheckForNullOrEmpty(string login, string password, string confirmPassword)
        {
            var isNullOrEmpty = (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(confirmPassword)) ? true : false;
            return isNullOrEmpty;
        }

        static bool CheckLogin(string login, int maxLength, char simbol)
        {
            var isRelevant = (login.Length <= maxLength && !login.Contains(simbol)) ? true : false;
            return isRelevant;
        }
        static bool CheckPassword(string pass, int maxLength, char simbol)
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
