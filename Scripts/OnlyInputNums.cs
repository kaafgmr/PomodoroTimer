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

        int column = lineEdit.CaretColumn;
        text = text.TrimPrefix("0");

        string numText = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsDigit(text, i))
            {
                numText += text[i]; 
            }
        }

        if (numText == "")
        {
            numText = "0";
            column = numText.Length;
        }

        lineEdit.Text = numText;
        lineEdit.CaretColumn = column;
    }
}
