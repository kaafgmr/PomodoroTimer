using Godot;

public partial class TimerBehaviour : RichTextLabel
{
	private int millis = 0;
	private int secs = 3;
	private int mins = 0;
    private bool timedout;

	public override void _Ready()
	{
        timedout = false;
		UpdateText();
	}

	private void UpdateTimer(int deltaTime)
	{
        if(timedout) return;
		UpdateValue(deltaTime);
		UpdateText();
	}

	private void UpdateValue(int deltaTime)
	{
		millis -= deltaTime;

		if (millis >= 0)  return;

		millis += 1000;

		secs -= 1;

		if (secs >= 0) return;

		secs += 59;

		mins -= 1;

		if(mins >= 0) return;

        timedout = true;
        millis = 0;
        secs = 0;
        mins = 0;
        GD.Print("Timeout!!!");
	}

	private void UpdateText()
	{
		Text = mins.ToString("00") + ":" + secs.ToString("00");
	}
}
