using System.Net.Mail;
using System.Text.RegularExpressions;
using TechExam3.Model;

namespace TechExam3.Valicator
{
    public class EmployeeValidator
    {
        public EmployeeValidator()
        {

        }

        public ValidatorResponse ValidateRequest(AddEmployeeRequest createEmployee)
        {
          
            ValidatorResponse response = new ValidatorResponse();
            try
            {

                if (string.IsNullOrEmpty(createEmployee.Name) ||
                   string.IsNullOrEmpty(createEmployee.Address) ||
                   string.IsNullOrEmpty(createEmployee.PhoneNumber) ||
                   string.IsNullOrEmpty(createEmployee.Position))
                {
                    response.HasError = true;
                    response.ErrorMessage = "All fields are required!";
                    return response;
                }
                string trimmedName = createEmployee.Name.Trim();
                var pattern = "^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$";
                var regex = new Regex(pattern);

                if (!regex.IsMatch(createEmployee.Name))
                {
                    response.HasError = true;
                    response.ErrorMessage = "Name contains invalid inputs.";
                    return response;
                }

                if (createEmployee.Name.Length > 100)
                {
                    response.HasError = true;
                    response.ErrorMessage = $"Name length should be less than 100.";
                    return response;
                }

                

                response.HasError = false;
            }
            catch (Exception e)
            {
                response.HasError = true;
                response.ErrorMessage = e.Message;
            }
            return response;
        }


        public ValidatorResponse ValidateEmailRequest(AddEmployeeRequest createEmployee)
        {
           
            ValidatorResponse response = new ValidatorResponse();
            try
            {

                if (string.IsNullOrEmpty(createEmployee.Email))
                {
                    response.HasError = true;
                    response.ErrorMessage = "Email can't be null or empty!";
                    return response;
                }

                var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

                var regex = new Regex(pattern);
                if (!regex.IsMatch(createEmployee.Email))
                {
                    response.HasError = true;
                    response.ErrorMessage = "Invalid email address.";
                    return response;
                }
                response.HasError = false;
            }
            catch (Exception e)
            {
                response.HasError = true;
                response.ErrorMessage = e.Message;
            }
            return response;
        }
        public ValidatorResponse ValidateEditRequest(EditEmployeeRequest editEmployeeRequest)
        {
            ValidatorResponse response = new ValidatorResponse();
            try
            {

                if (string.IsNullOrEmpty(editEmployeeRequest.Name))
                {
                    response.HasError = true;
                    response.ErrorMessage = "Name can't be null or empty!";
                    return response;
                }
                var pattern = "^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$";
                var regex = new Regex(pattern);
                if (!regex.IsMatch(editEmployeeRequest.Name))
                {
                    response.HasError = true;
                    response.ErrorMessage = "Name contains invalid inputs.";
                    return response;
                }
                if (editEmployeeRequest.Name.Length > 100)
                {
                    response.HasError = true;
                    response.ErrorMessage = "Name lenght must be less than 100.";
                    return response;
                }

                var patternEmail = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

                var regexEmail = new Regex(patternEmail);
                if (!regexEmail.IsMatch(editEmployeeRequest.Email))
                {
                    response.HasError = true;
                    response.ErrorMessage = "Invalid email address.";
                    return response;
                }

                response.HasError = false;
            }
            catch (Exception e)
            {
                response.HasError = true;
                response.ErrorMessage = e.Message;
            }
            return response;
        }
    }
}
