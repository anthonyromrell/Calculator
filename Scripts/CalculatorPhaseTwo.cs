using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PhaseTwo")]
public class CalculatorPhaseTwo : CalulatorPhase {

	public override void RunPhase()
	{
		Data.InputNext += IncomingTextHandler.ObjectText;
		Debug.Log(Data.Input);
		Data.ToOutputText(Data.InputNext);//GameAaction as String output
	}
}
