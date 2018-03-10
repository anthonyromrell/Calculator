using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Calculator")]
public class Calculator : ScriptableObject
{

    public CalulatorPhase StartPhase;

    private void OnEnable()
    {
        CalulatorPhase = StartPhase;
    }

    public CalulatorPhase CalulatorPhase;

    public void ChangePhase(CalulatorPhase calulatorPhase)
    {
        CalulatorPhase = calulatorPhase;
    }

    public void RunPhase()
    {
        CalulatorPhase.RunPhase();
    }

}
