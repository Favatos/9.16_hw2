namespace _9._16_hw2;

public class TurnOnState : IState
{
    int temperature;
    public TurnOnState()
    {
        while (temperature < 80 || temperature > 240)
        {
            Console.WriteLine("Enter the temperature: ");
            temperature = int.Parse(Console.ReadLine()!);
            if (temperature < 80 || temperature > 240)
            {
                Console.WriteLine("Wrong temperature");
            }
        }
        Console.WriteLine(this);
    }
    public int Temperature => temperature;

    public IState SwitchState(int num)
    {
        if (num == 1) return new TurnOffState();
        else
        {
            Console.WriteLine("Turn off the four first");
            return this;
        }
    }
    public override string ToString()
    {
        return $"Four is turn on. Temperature: {temperature}";
    }
}
