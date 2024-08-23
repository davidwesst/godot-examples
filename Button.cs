using Godot;
using System;
using DialogueManagerRuntime;

public partial class Button : Godot.Button
{
    public override void _Ready()
    {
		this.Pressed += OnPressed;       
    }

	void OnPressed()
	{
		Resource dialogueResource = GD.Load<Resource>("res://resources/test.dialogue");
		DialogueManager.ShowExampleDialogueBalloon(dialogueResource);
	}

	
}
