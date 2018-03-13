using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "SimpleCalculator")]
public class CalculatorConceptPhase2 : ScriptableObject
{
    //CalcVarsSO
    public string InputOne;
    public string InputTwo;
    public string InputThree;
    public string solution;
    public GameAction TextOut;

    private float tempNumOne;
    private float tempNumTwo;
    private float tempNumThree;

    //use GameAction to send to Text
    private string TempNext;

    //CalculationSO
    public void AddToInputOne(string num) //GameAaction as String input
    {
        InputOne += num;
        TextOut.Call(InputTwo); //GameAaction as String output
    }

    //CalculationSO
    public void AddToInputTwo(string num) //GameAaction as String input
    {
        InputTwo += num;
        TextOut.Call(InputTwo); //GameAaction as String output
    }

    //CalculationSO
    public void AddToInputThree(string num) //GameAaction as String input
    {
        InputThree += num;
        TextOut.Call(InputTwo); //GameAaction as String output
    }

    //CalculationSO
    public void Add()
    {
        solution = (tempNumOne + tempNumTwo).ToString();
        ResetDataTwo();
    }

    //CalculationSO
    public void Substract()
    {
        tempNumOne = ParseNumbers();

        solution = (tempNumOne - tempNumTwo).ToString();
        ResetDataTwo();
    }

    //CalculationSO
    public void MultiplyFirst()
    {
        solution = (tempNumOne * tempNumTwo).ToString();
        ResetDataTwo();
    }

    //CalculationSO
    public void MultiplyThenAdd()
    {
        solution = (tempNumOne + (tempNumTwo * tempNumThree)).ToString();
        ResetDataThree();
    }

    //CalculationSO
    public void MultiplyThenSubtract()
    {
        solution = (tempNumOne - (tempNumTwo * tempNumThree)).ToString();
        ResetDataThree();
    }

    //CalculationSO
    public void DivideFirst()
    {
        tempNumOne = ParseNumbers();
        solution = (tempNumOne / tempNumTwo).ToString();
        ResetDataTwo();
    }

    //CalculationSO
    public void DivideThenAdd()
    {
        solution = (tempNumOne + (tempNumTwo / tempNumThree)).ToString();
        ResetDataThree();
    }

    //CalculationSO
    public void DivideThenSubstract()
    {
        solution = (tempNumOne - (tempNumTwo / tempNumThree)).ToString();
        ResetDataThree();
    }

    private float ParseNumbers()
    {
        tempNumOne = float.Parse(InputOne);

        if (InputTwo != null)
        {
            TempNext = InputTwo;
            tempNumTwo = float.Parse(InputTwo);
        }
        else
        {
            tempNumTwo = float.Parse(TempNext);
        }

        return tempNumOne;
    }

    private void ResetDataTwo()
    {
        InputOne = solution;
        InputTwo = null;
        TextOut.Call(InputOne); //GameAction as String output
    }

    private void ResetDataThree()
    {
        InputOne = solution;
        InputTwo = null;
        InputThree = null;
        TextOut.Call(InputOne); //GameAction as String output
    }

    //CalculationSO
    public void Clear()
    {
        InputOne = null;
        InputTwo = null;
        InputThree = null;
        solution = null;

        TextOut.Call("0"); //GameAaction as String output
    }
}