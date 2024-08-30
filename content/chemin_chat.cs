using Godot;
using System;

public partial class chemin_chat : PathFollow2D
{
    [Export]
    private double VitesseChat = 1.0;

    [Export]
    private PackedScene Projectile;

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
        float avancement_chat = (float)(delta * VitesseChat);
        if (Input.IsActionPressed("Chat_Avance"))
		{
			ProgressRatio += avancement_chat;
        }
        else if (Input.IsActionPressed("Chat_Recule"))
        {
            ProgressRatio -= avancement_chat;
        }
        if (Input.IsActionJustPressed("Chat_Tire"))
        {
            BalleVilain projectile = Projectile.Instantiate<BalleVilain>();
            projectile.LinearVelocity = new Vector2 (1000, 0);
            //float direction = this.Rotation + Mathf.Pi / 2;
            //projectile.Rotation = -direction;
            //projectile.Position = this.Position;
            //projectile.LinearVelocity = Vector2.Right.Rotated(direction) * projectile.Vitesse;
            this.GetTree().CurrentScene.AddChild(projectile);
        }
    }
}
