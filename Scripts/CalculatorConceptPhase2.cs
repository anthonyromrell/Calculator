using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorConceptPhase2 : MonoBehaviour {

	//CalcVarsSO
	public string Input;
	public string InputNext;
	public string solution;

	//use GameAction to send to Text
	public Text LabelText;

	//CalculationSO
	public void one(string num)//GameAaction as String input
	{
		Input += num;
		LabelText.text = Input;//GameAaction as String output
	}
    
	//CalculationSO
	public void two(string num)//GameAaction as String input
	{
		InputNext += num;
		LabelText.text = InputNext;//GameAaction as String output
	}
    
	//CalculationSO
	public void Solve()
	{
		float tempNum = float.Parse(Input);
		float tempNumNext = float.Parse(InputNext);
		Calculate(tempNum, tempNumNext);
		Input = solution;
		LabelText.text = Input;//GameAaction as String output
	}

	//CalculationSO
	public void Clear()
	{
		Input = null;
		InputNext = null;
		solution = null;

		LabelText.text = "0";//GameAaction as String output
	}
    
	//CalculationTypeSO
	public void Calculate(float num, float nextNum)//AddSO
	{
		solution = (num + nextNum).ToString();
	}
}
