using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplacePressedButtonText : MonoBehaviour
{
    public int offsetX = 2, offsetY = 2;
    public RectTransform textRect;
    Vector3 pos;
    private Button button;

    void Start()
    {
        pos = textRect.localPosition;
        button = GetComponent<Button>();
    }

    public void Down()
    {
        if(button.interactable) 
            textRect.localPosition = new Vector3(pos.x + (float)offsetX, pos.y - (float)offsetY, pos.z);
    }

    public void Up()
    {
        if (button.interactable)
            textRect.localPosition = pos;
    }
}
