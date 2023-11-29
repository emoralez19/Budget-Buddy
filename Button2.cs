using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button2 : MonoBehaviour
{
    public int itemID;
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI quantityText;
    public GameObject shopManager2;

    void Update()
    {
        priceText.text = "Price: $" + shopManager2.GetComponent<ShopMang2>().shopItems[2, itemID].ToString();
        quantityText.text = shopManager2.GetComponent<ShopMang2>().shopItems[3, itemID].ToString();
    }
}
