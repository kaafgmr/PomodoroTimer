using Godot;

public partial class TimerUpdater : Timer
{
    [Signal] public delegate void TimeOutWaitTimeEventHandler(int waitTime);
    
    private const float SECONDS_TO_MILLISECONDS = 1000.0f;

    private void sendWaitTimeOnTimeOut()
    {
        int waitTimeInMillis = Mathf.FloorToInt((float)WaitTime * SECONDS_TO_MILLISECONDS);
        EmitSignal(SignalName.TimeOutWaitTime, waitTimeInMillis);        
    }
}
