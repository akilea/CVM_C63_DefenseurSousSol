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
                Nuage nuage = Nuage.Instantiate<Nuage>();
                nuage.LinearVelocity = new Vector2(100.0f, 0);
                float v = VitesseMin + GD.Randf() * (VitesseMax - VitesseMin);
                this.ProgressRatio = GD.Randf();
                nuage.Position = this.Position;
                this.GetTree().CurrentScene.AddChild(nuage);
			}
        }
    }
}
