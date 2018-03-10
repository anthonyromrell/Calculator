using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CalculatorData")]
public class CalculatorData : ScriptableObject { 
    
    public GameAction TextOutputAction;
    
    public string Input;
    public string InputNext;
    public string solution;

    public void ToOutputText(object obj)
    {
        TextOutputAction.Call(obj);
    }

    private void OnEnable()
    {
        Input = null;
        InputNext = null;
        solution = null;
    }
}
