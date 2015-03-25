using System;

namespace ConsoleApp1
{
    public class Program
    {

        bool numberFunction(int startAddend, int currentAddend, int sum) {
      
            if ((startAddend + currentAddend) == sum){ return true; }
                else { return false; }      
        }

        public static Tuple<int, int> TwoSum(int[] numbers, int target)
        {
            var lengthOfNumbers = numbers.Length;
            int firstGoodValue = 0;
            int secondGoodValue = 0;

            Console.WriteLine("Length is " + lengthOfNumbers);

            for(int i = 0; i < lengthOfNumbers; i++){

                if ((numbers[0] + numbers[i]) == target){
                    firstGoodValue = numbers[0];
                    secondGoodValue = numbers[i];
                }else {
                    
                }

            }
            
            // once we have our result:
            var ourResult = new Tuple<int, int>(firstGoodValue, secondGoodValue);
            return ourResult;
        }
 
        private static void Main(string[] args)
        {
            int[] ourNumbers = {2, 7, 11, 15};
            var ourTarget = 9;
 
            var ourFinalResult = TwoSum(ourNumbers, ourTarget);
 
            Console.WriteLine(ourFinalResult);
            Console.ReadLine();
        }
    }
}

