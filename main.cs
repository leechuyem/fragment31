using Godot;
using System;

public class main : CanvasLayer
{
    private Label _letter;
    private LineEdit _lineEdit;
    public override void _Ready()
    {
        _letter = GetNode<Label>("Letter");
        _lineEdit = GetNode<LineEdit>("LetterInput");
        _lineEdit.GrabFocus();
    }

    public override void _Process(float delta)
    {
    }

    public override void _Input(InputEvent ev)
    {
        if (ev is InputEventKey keyEv)
        {
            var input = _lineEdit.Text;

            if (input == _letter.Text)
            {
                _letter.AddColorOverride("font_color", new Color(1, 0.5f, 0.31f, 1));
            }

            _lineEdit.Clear();
        }
    }
}