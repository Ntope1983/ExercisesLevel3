public class Program
{
    private static void Main(string[] args)
    {/* 
         Person person1 = new Person("Ioannis", "Polidoras", 42);
         Person person2 = new Person("Ioannis", "Polidoras", 42);
         Person person3 = new Person("Ioannis", "Polidoras", 42);
         Person person4 = new Person("Ioannis", "Polidoras", 42);
         Person person5 = new Person("Ioannis", "Polidoras", 42);
         Person person6 = new Person("Ioannis", "Polidoras", 42);



         List<Person> Pupils = new List<Person> { person1, person2, person3, person4, person5, person6 };


     }



     private static bool IsPrime(int number)
     {
         if (number < 2)
         {
             return false;
         }
         for (int i = 2; i < number; i++)
         {
             if (number % i == 0)
             {
                 return false;
             }
         }
         return true;
        */
        BankAccount x = new BankAccount(121.2m);
        try
        {
            x.Withdraw(122.2m);
        }
        catch (Issufficientfundexception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    }



}