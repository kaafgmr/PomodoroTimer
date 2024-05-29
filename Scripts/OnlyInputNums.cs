using Godot;

public partial class OnlyInputNums : Node 
{
    [Export] LineEdit lineEdit;
    
    public override void _Ready()
    {
        lineEdit.TextChanged += RemoveEachChar;
    }

    private void RemoveEachChar(string text)
    {
        if (text.Length == 0) return;

        string numText = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsDigit(text, i))
            {
                numText += text[i]; 
            }
        }

        lineEdit.Text = numText;
        lineEdit.CaretColumn = lineEdit.Text.Length;
    }
}
