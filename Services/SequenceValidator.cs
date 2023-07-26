using System.Text.RegularExpressions;

namespace PasswordValidationService.Services
{
    public class SequenceValidator
    {
        // 不得為全部連續字元。
        public bool IsValid(string value)
        {
            return Regex.IsMatch(value, "(.+?)(\\1+?)");
        }
    }
}
