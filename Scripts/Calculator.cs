using System.CodeDom.Compiler;
using System.Globalization;
using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu(fileName = "Calculator")]
public class Calculator : ScriptableObject
{
	public string Input0, Input1, Input2;
	private float float0, float1, float2;	
	public bool Add, Subtract, Multiply, Divide;
	public string solution;
	
	public void GetInput(string input)
	{
		if (!(Add || Subtract) && !(Multiply || Divide))
			Input0 = input;
		
		
		if (Add || Subtract || Multiply || Divide)
			Input1 = input;
	

		if ((Add || Subtract) && (Multiply || Divide))
			Input2 = input;
	}

	public string Operate(string _operator)
	{
		float0 = float.Parse(Input0);
		float1 = float.Parse(Input1);
		float2 = float.Parse(Input2);

		var solution = float.Parse(_operator);

		if (Add)
		{
			solution = float0 + float1;
		} 

		if (Subtract)
		{
			solution = float0 - float1;
		}

		if (Multiply)
		{
			solution = float0 * float1;
			Divide = false;
		}

		if (Divide)
		{
			solution = float0 / float1;
			Divide = false;
		}

		if (Add && Multiply)
		{
			solution = float0 + float1 * float2;
			Multiply = false;
		}

		if (Add && Divide)
		{
			solution = float0 + float1 / float2;
			Divide = false;
		}

		if (Subtract && Multiply)
		{
			solution = float0 - float1 * float2;
			Multiply = false;
		}
	
		if (Subtract && Divide)
		{
			solution = float0 - float1 / float2;
			Divide = false;
		}
		
		return solution.ToString(CultureInfo.InvariantCulture);
	
	}

	public void AddOperation()
	{
		
	}
	
	public void SubtractOperation()
	{
		
	}
	
	public void MultiplyOperation()
	{
		
	}
	
	public void DivideOperation()
	{
		
	}
}