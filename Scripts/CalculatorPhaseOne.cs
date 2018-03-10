using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PhaseOne")]
public class CalculatorPhaseOne : CalulatorPhase {
    
    public override void RunPhase ()//GameAaction as String input
    {
        Data.Input += IncomingTextHandler.ObjectText;
        Debug.Log(Data.Input);
        Data.ToOutputText(Data.Input);//GameAaction as String output
    }
    
}
