using System.Collections.Generic;
using UnityEngine;

public class Add : Operation 
{
	
	
	
	public override void Operate(List<float> numbers)
	{
		if (numbers.Count == 1)
		{
			numbers.Add(0);
			//numbers[1] == value;
		}
		else
		{
			numbers[0] += numbers[1];
		}
	}
}
