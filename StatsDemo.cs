using Godot;
using System;

public partial class StatsDemo : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	
Stats original = new Stats(100, 10);
Stats copy = original;
copy.Energy = 40;
GD.Print(original.Energy);
GD.Print(copy.Energy);   
	}

	
}
