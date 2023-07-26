using System.Text.RegularExpressions;

namespace PasswordValidationService.Services
{
    public class LengthValidator
    {
        // 長度必須介於 5 到 12 個字元之間。
        public bool IsValid(string value)
        {
            return value.Length >= 5 && value.Length <= 12;
        }
    }
}
