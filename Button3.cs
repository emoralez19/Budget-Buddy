using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Button3 : MonoBehaviour
{
    public int itemID;
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI quantityText;
    public GameObject shopManager3;

    void Update()
    {
        priceText.text = "Price: $" + shopManager3.GetComponent<ShopMang3>().shopItems[2, itemID].ToString();
        quantityText.text = shopManager3.GetComponent<ShopMang3>().shopItems[3, itemID].ToString();
    }
}
