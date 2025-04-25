using Godot;

public partial class IncDecNum : Node
{
    [Export] private LineEdit numToEdit;
    [Export] private bool onlyPositive;
    [Export] private int amount;  

    void IncreaseNumber()
    {
        int newNumber = numToEdit.Text.ToInt() + amount;

        numToEdit.Text = newNumber.ToString(); 
    }

    void DecreaseNumber()
    {
        int newNumber = numToEdit.Text.ToInt() - amount;
        if (newNumber < 0)
        {
            newNumber = 0;
        }

        numToEdit.Text = newNumber.ToString(); 
    }
}
