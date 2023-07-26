namespace PasswordValidationService.Models
{
    public class ValidatorModel
    {
        public bool? Valid { get; set; }
        public bool? LengthValidator { get; set; }
        public bool? CharCaseValidator { get; set; }
        public bool? SequenceValidator { get; set; }
    }
}
