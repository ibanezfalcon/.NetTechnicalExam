using Microsoft.AspNetCore.Mvc.Infrastructure;
using TechExam3.Model;
using TechExam3.Valicator;

namespace CRUDUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Validate_Employee_Info()
        {
            //Arrange
            var validation = new EmployeeValidator();
            var testEmployeeInfo = new AddEmployeeRequest
            {
                Name = "Daniel Ibanez",
                PhoneNumber = "099360938329", 
                Address = "107-D Santol St. Balingasa QC",
                Position = "Software Dev"
               
            };
        
            var result = validation.ValidateRequest(testEmployeeInfo);
            Assert.IsFalse(result.HasError);
            Assert.AreNotEqual("All fields are required!", result.ErrorMessage);

            
            testEmployeeInfo.Name = "Daniel Ibanez";
        
            result = validation.ValidateRequest(testEmployeeInfo);
            Assert.IsFalse(result.HasError);
            Assert.AreNotEqual("Name contains invalid inputs.", result.ErrorMessage);


            //testEmployeeInfo.Name = "Very Long Name That Exceeds One Hundred Characters And Should Fail Validation Very Long Name That Exceeds One Hundred Characters And Should Fail Validation Very Long Name That Exceeds One Hundred Characters And Should Fail Validation";
            testEmployeeInfo.Name = "Daniel Ibanez";

            result = validation.ValidateRequest(testEmployeeInfo);
            Assert.IsFalse(result.HasError);
            Assert.AreNotEqual("Name length should be less than 100.", result.ErrorMessage);
        }
        [TestMethod]
        public void Validate_Employee_Email()
        {
            var validation = new EmployeeValidator();
            var testEmployeeInfo = new AddEmployeeRequest
            {
                Email = "ibanezfalconf@gmail.com"
            };

            var result = validation.ValidateEmailRequest(testEmployeeInfo);
            Assert.IsFalse(result.HasError);
            Assert.AreNotEqual("Name can't be null or empty!", result.ErrorMessage);


            testEmployeeInfo.Email = "ibanezfalconf@gmail.com";
            result = validation.ValidateEmailRequest(testEmployeeInfo);
            Assert.IsFalse(result.HasError);
            Assert.AreNotEqual("Invalid email address.", result.ErrorMessage);

           

        }


        [TestMethod]
        public void Validate_Employee_Edit_Info()
        {
            var validation = new EmployeeValidator();
            var testEditEmployee = new EditEmployeeRequest
            {
                Name = "Daniel Ibanez",
                Email = "ibanezfalconf@gmail.com",
                PhoneNumber = "099360938329",
                Address = "107-D Santol St. Balingasa QC",
                Position = "Software Dev"
               
            };

            var result = validation.ValidateEditRequest(testEditEmployee);
            Assert.IsFalse(result.HasError);
            Assert.AreNotEqual("All fields are required!", result.ErrorMessage);


            testEditEmployee.Name = "Daniel Ibanez";

            result = validation.ValidateEditRequest(testEditEmployee);
            Assert.IsFalse(result.HasError);
            Assert.AreNotEqual("Name contains invalid inputs.", result.ErrorMessage);


           
            testEditEmployee.Name = "Daniel Ibanez";

            result = validation.ValidateEditRequest(testEditEmployee);
            Assert.IsFalse(result.HasError);
            Assert.AreNotEqual("Name length should be less than 100.", result.ErrorMessage);


            testEditEmployee.Email = "ibanezfalconf@gmail.com";
            result = validation.ValidateEditRequest(testEditEmployee);
            Assert.IsFalse(result.HasError);
            Assert.AreNotEqual("Invalid email address.", result.ErrorMessage);

        }


    }
}