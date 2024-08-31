using Godot;
using System;

public partial class chemin_chat : PathFollow2D
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
            BalleVilain projectile = Projectile.Instantiate<BalleVilain>();
            projectile.Position = this.Position;
            this.GetTree().CurrentScene.AddChild(projectile);
        }
    }
}
