using System.Collections.Generic;
using UnityEngine;

public class CalcOperation : ScriptableObject
{

	public Operation Operation;

	public List<float> Numbers;

	private void OnEnable()
	{
		Numbers = new List<float>();
		Numbers.Add(0);
	}

	public void NextNumber()
	{
		Numbers.Add(0);
	}
	
	public void Calc()
	{
		Operation.Operate(Numbers);
	}
}
