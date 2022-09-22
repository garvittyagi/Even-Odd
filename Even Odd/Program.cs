namespace Even_Odd
{
    public class evenodd
    {

        double number1 = Convert.ToDouble(Console.ReadLine());
        double number2 = Convert.ToDouble(Console.ReadLine());

        public bool pgm()
        {
            if (number1 % 2 == 0 && number2 % 2 == 0)
                return true;
            else
                return false;
        }
            
    }

    class Program
    {
        static void Main(string[] args)
        {
            evenodd obj = new evenodd();
            Console.WriteLine(obj.pgm());
                

                
        }
    }
}