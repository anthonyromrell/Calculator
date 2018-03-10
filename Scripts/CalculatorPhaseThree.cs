using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PhaseTree")]
public class CalculatorPhaseThree : CalulatorPhase {

	public override void RunPhase()
	{
		float tempNum = float.Parse(Data.Input);
		float tempNumNext = float.Parse(Data.InputNext);
		Calculate(tempNum, tempNumNext);
		Data.Input = Data.solution;
		Data.ToOutputText(Data.Input);//GameAaction as String output
	}

	private void Calculate(float num, float nextNum)//AddSO
	{
		Data.solution = (num + nextNum).ToString();
	}
}
