namespace _9._16_hw2;

public class TurnOffState : IState
{
    public int Temperature => 0;
    public TurnOffState()
    {
        Console.WriteLine(this);
    }

    public IState SwitchState(int num)
    {
        if (num == 3) return new TurnOnTimerState();
        else if (num == 2) return new TurnOnState();
        else return this;
    }

    public override string ToString()
    {
        return "Four is turn off";
    }
}
