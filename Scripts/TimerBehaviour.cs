using Godot;

public partial class TimerBehaviour : Label
{
    private int millis = 1000;
    private int secs = 59;
    private int mins = 15;

    private void UpdateTimer(int deltaTime)
    {
        UpdateValue(deltaTime);
        UpdateText();
    }

    private void UpdateValue(int deltaTime)
    {
        millis -= deltaTime;

        if (millis > 0)  return;

        millis = 1000 - deltaTime;

        secs -= 1;

        if (secs > 0) return;

        secs = 59;

        mins -= 1;

        if(mins > 0) return;

        GD.Print("Timeout!!!");
    }

    private void UpdateText()
    {
        Text = mins + ":" + secs;
    }
}
