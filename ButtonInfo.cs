using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonInfo : MonoBehaviour
{
    public int itemID;
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI quantityText;
    public GameObject shopManager;

    void Update()
    {
        priceText.text = "Price: $" + shopManager.GetComponent<ShopManagerScript>().shopItems[2, itemID].ToString();
        quantityText.text = shopManager.GetComponent<ShopManagerScript>().shopItems[3, itemID].ToString();
    }
}
