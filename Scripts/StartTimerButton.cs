using Godot;

public partial class StartTimerButton : Button
{
    [Export] private Timer timerDelta;

    public override void _Pressed()
    {
        base._Pressed();
        
        if (Text == "Start")
        {
            Text = "Stop";
            timerDelta.Start();
        }
        else
        {
            Text = "Start";
            timerDelta.Stop();
        }
    }
}
