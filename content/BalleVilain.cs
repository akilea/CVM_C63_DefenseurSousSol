using Godot;
using System;

public partial class BalleVilain : RigidBody2D
{

	[Export]
	public float Vitesse = 1000.0f;

	public override void _Ready()
	{
		LinearVelocity = this.Transform.X * Vitesse;
	}
}
