//using MethodsExercise;

namespace MethodsExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello User! What is your name? ");
            string name = Console.ReadLine();
            
            Console.WriteLine($"Thanks, {name}. Now what's your favorite color?");
            string favColor = Console.ReadLine();
            
            Console.WriteLine($"Great! I like the color {favColor} too. Now what is your favorite animal?");
            string favAnimal = Console.ReadLine();
            
            Console.WriteLine("Perfect! Lastly, Now what is your favorite type of car?");
            string favCar = Console.ReadLine();
            
            Console.WriteLine($"Thanks for the info, {name}. Now I'm going to create a story with the info you gave me. ");
            Console.WriteLine($"\n{name} went for a drive in his {favColor} {favCar} to the petstore to buy a {favAnimal}.");

            Console.WriteLine(AddMethod.Add(5, 7));
            Console.WriteLine(SubtractMethod.Subtract(9, 7));
            Console.WriteLine(MultiplyMethod.Multiply(9, 7));
            Console.WriteLine(DivideMethod.Divide(10, 2));
            Console.WriteLine(ModulusMethod.Modulus(5, 7));



            Console.WriteLine(ParamsMethod.AddMultiNum(1, 7, 4, 5, 7));

        }

   
    }
}
