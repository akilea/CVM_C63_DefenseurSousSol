using Godot;
using System;

public partial class EmetteurNuage : PathFollow2D
{

	[Export]
	private float VitesseMin;
	[Export]
	private float VitesseMax;
	[Export]
	private PackedScene Nuage;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("Chat_Tire"))
		{
			if (GD.Randi() % 2 == 0)
			{
				BalleVilain nuage = Nuage.Instantiate<BalleVilain>();
				nuage.LinearVelocity = new Vector2(100, 0);
				float v = VitesseMin + GD.Randf() * (VitesseMax - VitesseMin);
				this.ProgressRatio = GD.Randf();
				nuage.Position = this.Position;
				nuage.ZIndex = 2;
				this.GetTree().CurrentScene.AddChild(nuage);
			}
		}
	}
}
