using Godot;
using System;



public partial class NewScript : Node
{
			public class Participant
{
	public string Name = "";
	public int Energy;
	public int Level = 1;
}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{


Participant anna = new Participant();
anna.Name = "Anna";
anna.Energy = 75;
GD.Print(anna.Name, ": ", anna.Energy, ", līmenis ", anna.Level);

Participant janis = new Participant();
anna.Name = "Jānis";
anna.Energy = 80;
GD.Print(janis.Name, ": ", janis.Energy, ", līmenis ", janis.Level);
		
		
		
		
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
