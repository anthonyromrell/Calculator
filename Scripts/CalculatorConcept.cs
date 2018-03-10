using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Calculator")]
public class CalculatorConcept : ScriptableObject
{
	//CalcVarsSO
	public string Input;
	public string InputNext;
	public string solution;

	//use GameAction to send to Text
	public Text LabelText;

	//CalculationSO
	public void one(string num)
	{
		Input += num;
		LabelText.text = Input;
	}
    
	//CalculationSO
	public void two(string num)
	{
		InputNext += num;
		LabelText.text = InputNext;
	}
    
	//CalculationSO
	public void Solve(string num, string nextNum)
	{
		float tempNum = float.Parse(num);
		float tempNumNext = float.Parse(nextNum);
		Add(tempNum, tempNumNext);
		Input = solution;
		LabelText.text = Input;
	}

	//CalculationSO
	public void Clear()
	{
		Input = null;
		InputNext = null;
		solution = null;

		LabelText.text = "0";
	}
    
	//CalculationTypeSO
	public void Add(float num, float nextNum)
	{
		solution = (num + nextNum).ToString();
	}
}
