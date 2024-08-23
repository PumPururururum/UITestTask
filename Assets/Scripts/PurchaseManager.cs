using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PurchaseManager : Subject
{
    public float startingMoney;
    private float currentMoney;

    public TMP_Text moneyText;

    private void Start()
    {
        currentMoney = startingMoney;
    }
    public void Buy(float cost)
    {
        if (CheckAffordability(cost))
        {
            currentMoney-=cost;
            moneyText.text = string.Format("{0:0.00}", currentMoney) +"T";
            NotifyObservers();
        }
    }
    public bool CheckAffordability(float cost)
    {
        if (currentMoney >= cost)
            return true;
        else
            return false;
    }
}
