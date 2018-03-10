using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PhaseTree")]
public class CalculatorPhaseThree : CalulatorPhase
{

	private string TempNext;
	
	public override void RunPhase()
	{
		float tempNum = float.Parse(Data.Input);
		float tempNumNext;

		if (Data.InputNext != null)
		{
			TempNext = Data.InputNext;
			tempNumNext = float.Parse(Data.InputNext);
		}
		else
		{
			tempNumNext = float.Parse(TempNext);
		}

		Calculate(tempNum, tempNumNext);
		Data.Input = Data.solution;
		Data.InputNext = null;
		Data.ToOutputText(Data.Input);//GameAaction as String output
	}

	private void Calculate(float num, float nextNum)//AddSO
	{
		Data.solution = (num + nextNum).ToString();
	}
}