using Godot;
using System;

public partial class LessonDemo : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Participant anna = new Participant("Anna", 9999);
		Participant janis = new Participant("Jānis", 80);
		GD.Print(anna.Name, ": ", anna.GetEnergy());
		anna.ApplyPenalty(30);
		GD.Print(anna.Name, ": ", anna.GetEnergy());
		GD.Print(janis.Name, ": ", janis.GetEnergy());
		anna.ApplyPenalty(100);
		GD.Print("Anna: ", anna.GetEnergy(), ", aktīva: ", anna.IsActive());
		
		
	}

}
