using Godot;
using System;


public partial class PlayerInput : Node2D
{
	private Vector2 _movementInput = Vector2.Zero;
	
	public Vector2 MovementInput => _movementInput;

	public override void _Process(double delta)
	{
		_movementInput = new Vector2(
			Input.GetAxis(negativeAction: "Left", positiveAction: "Right"),
			Input.GetAxis(negativeAction: "Up", positiveAction: "Down")
		);
	}

}
