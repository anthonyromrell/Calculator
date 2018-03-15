using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Calculator")]
public class Calculator : ScriptableObject
{

    public CalulatorPhase StartPhase;
    public CalulatorPhase CalulatorPhase;
    public Operation Operation;

    private void OnEnable()
    {
        CalulatorPhase = StartPhase;
    }

    public void ChangePhase(CalulatorPhase calulatorPhase)
    {
        CalulatorPhase = calulatorPhase;
    }

    public void RunPhase()
    {
        CalulatorPhase.RunPhase();
    }
    
    public void ChangeOperation(Operation operation)
    {
        Operation = operation;
    }

    public void RunOperation()
    {
      //  Operation.Operate();
    }
    
    
     
}