using Godot;
using System;
namespace UnicornGame;
public partial class BloodParticleEffect : CpuParticles2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Emitting = true; // Start emitting particles immediately
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
