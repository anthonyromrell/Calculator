using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PhaseOne")]
public class CalculatorPhaseOne : CalulatorPhase {
    
    public override void RunPhase ()//GameAaction as String input
    {
        Data.InputOne += IncomingTextHandler.ObjectText;
        Data.ToOutputText(Data.InputOne);//GameAaction as String output
    }
    
}
