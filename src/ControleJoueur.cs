using Godot;
using System;

public partial class ControleJoueur : PathFollow2D
{
    [Export]
    private double VitesseChat = 1.0;

    [Export]
    private PackedScene Projectile;

    [Export]
    private String ActionAvance;

    [Export]
    private String ActionRecule;

    [Export]
    private String ActionTire;

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
        float avancement_chat = (float)(delta * VitesseChat);
        if (Input.IsActionPressed(ActionAvance))
		{
			ProgressRatio += avancement_chat;
        }
        else if (Input.IsActionPressed(ActionRecule))
        {
            ProgressRatio -= avancement_chat;
        }
        if (Input.IsActionJustPressed(ActionTire))
        {
            Projectile projectile = Projectile.Instantiate<Projectile>();
            //projectile.LinearVelocity = new Vector2(1000, 0);
            //Direction de la fleche verte
            Vector2 direction = this.Transform.Y;
            //Regarde dans cette direction
            projectile.LookAt(direction);
            projectile.Position = this.Position;
            //Ready sera appele apres, donc le boulet est lance par la suite.
            this.GetTree().CurrentScene.AddChild(projectile);
        }
    }
}
