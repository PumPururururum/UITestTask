using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeSlot : MonoBehaviour
{
    private UpgradeSO upgrade;
    public bool isFull;

    public Image image;
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public TMP_Text costText;
    public Button buyButton;
    

    public PurchaseManager purchaseManager;

    public void AddUpgrade(UpgradeSO upgrade)
    {
        this.upgrade = upgrade;
        isFull = true;
        SetUI();
    }
    public void BuyUpgrade()
    {
        purchaseManager.Buy(upgrade.cost);
        gameObject.SetActive(false);
        isFull = false;
    }
    private void SetUI()
    {
        image.sprite = upgrade.sprite;
        nameText.text = upgrade.upgradeName;
        descriptionText.text = upgrade.description;

        costText.text = upgrade.cost + "T";
        SetButton();
    }

    public void SetButton()
    {
        purchaseManager = GameObject.Find("PurchaseManager").GetComponent<PurchaseManager>();
        if (purchaseManager.CheckAffordability(upgrade.cost))
        {
            buyButton.interactable = true;
        }
        else
        {
            buyButton.interactable = false;
        }
    }
}
