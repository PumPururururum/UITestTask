using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject UpgradeMenu;
    public void TurnOnUpgradeMenu()
    {
        UpgradeMenu.SetActive(true);
        UpgradeMenu.transform.Find("PanelUpgrades").GetComponent<Animator>().SetTrigger("Open");
    }
    public void TurnOffUpgradeMenu() 
    { 
        UpgradeMenu.SetActive(false);
    }
    public void BuyUpgrade()
    {

    }

}
