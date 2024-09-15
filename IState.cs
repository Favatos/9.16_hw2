namespace _9._16_hw2;

public interface IState
{
    public int Temperature { get; }
    public IState SwitchState(int num);
}
