using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PhaseTwo")]
public class CalculatorPhaseTwo : CalulatorPhase {

	public override void RunPhase()
	{
		Data.InputTwo += IncomingTextHandler.ObjectText;
		Data.ToOutputText(Data.InputTwo);//GameAaction as String output
	}
}
