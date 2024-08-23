using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesManager : MonoBehaviour, IObserver
{
    public UpgradeSlot[] upgradeSlots;
    public UpgradeSO[] upgrades;
    [SerializeField]
    Subject _purchaseSubject;
    void Start()
    {
        foreach(UpgradeSO upgrade in upgrades)
        {
            AddUpgrade(upgrade);
        }
    }
    private void OnEnable()
    {
        _purchaseSubject.AddObserver(this);
    }
    private void OnDisable()
    {
        _purchaseSubject.RemoveObserver(this);
    }
    private void AddUpgrade(UpgradeSO upgrade)
    {
        foreach (UpgradeSlot slot in upgradeSlots)
        {
            if (!slot.isFull)
            {
                slot.AddUpgrade(upgrade);
                return;
            }

        }
    }
    public void OnNotify()
    {
        UpdateAffordabillity();
    }
    private void UpdateAffordabillity()
    {
        foreach (UpgradeSlot slot in upgradeSlots)
        {
            slot.SetButton();
        }
    }
}

