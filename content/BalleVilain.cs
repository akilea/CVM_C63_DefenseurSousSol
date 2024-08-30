using Godot;
using System;

public partial class BalleVilain : RigidBody2D
{

	[Export]
	public float Vitesse = 1000.0f;
	public override void _Ready()
	{
		LinearVelocity = new Vector2 (Vitesse, 0);
	}

	public override void _Process(double delta)
	{
	}
}
