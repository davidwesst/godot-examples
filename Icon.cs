using Godot;
using System;

public partial class Icon : Sprite2D
{
    public override void _PhysicsProcess(double delta)
    {
        if(Input.IsActionPressed("ui_accept"))
		{
			this.Rotate(0.1f);
		}
    }
}
