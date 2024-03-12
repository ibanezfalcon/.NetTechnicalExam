using TechExam2.Interface;

namespace TechExam2.Service
{
    public class CalculatorService : ICalculatorService
    {
        //public async Task<int> RoundingSumOf2Int(int firstNumber, int secondNumber)
        //{
        //    int roundedValue = 0;
        //    int sum = 0;

        //    sum = firstNumber + secondNumber;
        //    roundedValue = (sum % 5) == 0 ? sum : sum + 5;


        //    return roundedValue;
        //}

        public async Task<int> RoundingSumOf2Int(int firstNumber, int secondNumber)
        {
            
            int sum = firstNumber + secondNumber;
            int remainder = sum % 5; // Get the remainder
            int roundedValue = remainder >= 3 ? sum + (5 - remainder) : sum; // Round up only kapag greater than 3 or equal to 3 yung remainder

            return roundedValue;
        }
    }
}
