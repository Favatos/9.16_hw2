namespace _9._16_hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Four four = new Four();
            while (true)
            {
                Console.WriteLine("1- Turn off \n2 - Turn on \n3 - Turn on with timer \n0 - Exit");
                int num = int.Parse( Console.ReadLine() );
                four.State = four.State.SwitchState(num);
                if (num== 0)
                {
                    break;
                }
            }
        }
    }
}
