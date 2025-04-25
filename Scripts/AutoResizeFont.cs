using Godot;

[Tool]
public partial class AutoResizeFont : LineEdit
{
    [Export(PropertyHint.Range, "0.0, 0.6")] private float multiplier; 
    
    public override void _Ready()
    {
        Resized += OnResize;    
        OnResize();
    }

    public override void _Process(double delta)
    {
        if(Engine.IsEditorHint())
        {
            OnResize();
        }
    }

    private void OnResize()
    {
        float newSize = (float)Size.Y * multiplier;

        AddThemeFontSizeOverride("font_size", (int)newSize);

    }
}
