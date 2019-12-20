using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondCollector : MonoBehaviour
{
    public static int diamondsAmount = 0;
    public Text diamondsAmountText;
    public bool allDiamondsTaken = false;
    public int AmountOfAllDiamonds = 3;

    private void Awake()
    {

    }

    public int GetDiamondsAmount()
    {
        return diamondsAmount;
    }

    public void AddDiamond()
    {
        diamondsAmount++;
        if(diamondsAmount >= AmountOfAllDiamonds)
        {
            allDiamondsTaken = true;
        }
        diamondsAmountText.text = diamondsAmount.ToString()+"/"+AmountOfAllDiamonds.ToString();
    }
}
