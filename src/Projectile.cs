using Godot;
using System;
using System.Security.Cryptography;

public partial class Projectile : RigidBody2D
{
	[Export]
	public float Vitesse = 1000.0f;

	public override void _Ready()
	{
		ContactMonitor = true;
		MaxContactsReported = 1;
		LinearVelocity = this.Transform.X * Vitesse;
	}

	private void OnExitScreen()
	{
		this.QueueFree();
	}

	private void OnCollision(Node body)
	{
        this.GetTree().ReloadCurrentScene();
    }

}
