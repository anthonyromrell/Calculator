using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PhaseTree")]
public class CalculatorPhaseThree : CalulatorPhase
{
	private string TempNext;
	
	public override void RunPhase()
	{
		float tempNum = float.Parse(Data.InputOne);
		float tempNumNext;

		if (Data.InputTwo != null)
		{
			TempNext = Data.InputTwo;
			tempNumNext = float.Parse(Data.InputTwo);
		}
		else
		{
			tempNumNext = float.Parse(TempNext);
		}

		Operate(tempNum, tempNumNext);
		ResetData();
	}

	private void ResetData()
	{
		Data.InputOne = Data.solution;
		Data.InputTwo = null;
		Data.ToOutputText(Data.InputOne); //GameAaction as String output
	}

	private void Operate (float num, float nextNum)//AddSO
	{
		Data.solution = (num + nextNum).ToString();
	}
}