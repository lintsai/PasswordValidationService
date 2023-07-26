using System.Text.RegularExpressions;

namespace PasswordValidationService.Services
{
    public class CharCaseValidator
    {
        // 必須僅由小寫字母和數位混合組成。
        public bool IsValid(string value)
        {
            return Regex.IsMatch(value, "^(?=.*[a-z])(?=.*\\d)[a-z\\d]*$");
        }
    }
}
