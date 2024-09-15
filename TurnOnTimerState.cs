namespace _9._16_hw2;

public class TurnOnTimerState : IState
{
    int temperature;
    int timer;
    public TurnOnTimerState()
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
        Console.WriteLine("Enter time: ");
        timer = int.Parse(Console.ReadLine()!) ;
        Console.WriteLine(this);
        Thread.Sleep(timer * 1000);
        this.SwitchState(1);
    }
    public int Temperature => temperature;

    public IState SwitchState(int num)
    {
        if (num == 1) return new TurnOffState();
        else if (num == 2) return new TurnOnState();   
        else
        {
            return this;
        }
    }

    public override string ToString()
    {
        return $"Four is turn on with timer. Temperature: {temperature}. Timer: {timer}";
    }
}
