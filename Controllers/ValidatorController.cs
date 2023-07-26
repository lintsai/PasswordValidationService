using Microsoft.AspNetCore.Mvc;
using PasswordValidationService.Models;
using PasswordValidationService.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PasswordValidationService.Controllers
{
    [ApiController]
    public class ValidatorController : ControllerBase
    {
        // GET api/<ValidatorController>/password
        // Sample: https://localhost:7192/validator?password=password
        [HttpGet]
        [Route("validator")]
        public ValidatorModel validator([FromUri]string? password)
        {
            ValidatorModel validatorModel = new ValidatorModel();
            if (password != null)
            {
                // 小寫與數字驗證
                validatorModel.CharCaseValidator = new CharCaseValidator().IsValid(password);
                // 長度驗證
                validatorModel.LengthValidator = new LengthValidator().IsValid(password);
                // 不連續字元驗證
                validatorModel.SequenceValidator = new SequenceValidator().IsValid(password);
                if (validatorModel.CharCaseValidator == true
                    && validatorModel.LengthValidator == true
                    && validatorModel.SequenceValidator == true)
                {
                    validatorModel.Valid = true;
                }
                else
                {
                    validatorModel.Valid = false;
                }
            }
            else
            {
                // 未傳資料判斷
                validatorModel.Valid = false;
                validatorModel.CharCaseValidator = false;
                validatorModel.LengthValidator = false;
                validatorModel.SequenceValidator = false;
            }

            return validatorModel;
        }
    }
}
