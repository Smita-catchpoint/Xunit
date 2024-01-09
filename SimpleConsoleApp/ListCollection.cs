
namespace SimpleConsoleApp
{
    public class ListCollection
    {
   
        public static List<int> FilterEvenNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0).ToList();
        }

        public static void Main()
        {
            
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = FilterEvenNumbers(numbers);

            Console.WriteLine("Original Numbers: " + string.Join(", ", numbers));
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
        }
    }
}

