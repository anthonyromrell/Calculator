using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CalculatorData")]
public class CalculatorData : ScriptableObject { 
    
    public GameAction TextOutputAction;
    
    public string InputOne;
    public string InputTwo;
    public string InputThree;
    public string solution;
    public Operator CurrentOperator;

    public void ToOutputText(object obj)
    {
        TextOutputAction.Call(obj);
    }

    private void OnEnable()
    {
        InputOne = null;
        InputTwo = null;
        solution = null;
    }

    public void OperatorCheck()
    {
        switch (CurrentOperator.name) 
        {
            case "+" :
                    
                break;
            case "-" :
                    
                break;
            case "*" :
                    
                break;
            case "/" :
                    
                break;
        }
    }
}
