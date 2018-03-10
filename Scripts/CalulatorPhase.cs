using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CalulatorPhase : ScriptableObject
{
	
	public CalculatorData Data;
	public TextActionHandler IncomingTextHandler;

	public abstract void RunPhase();
}