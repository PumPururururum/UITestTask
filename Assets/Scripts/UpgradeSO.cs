using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class UpgradeSO : ScriptableObject 
{
    public string upgradeName;
    public string description;
    public float cost;
    public Sprite sprite;
}
