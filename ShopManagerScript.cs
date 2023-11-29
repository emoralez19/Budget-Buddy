using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ShopManagerScript : MonoBehaviour
{
    // 41 items in total
    public int[,]shopItems = new int [41,41];
    public float money;
    public TextMeshProUGUI moneyTxt;

    void Start()
    {
        moneyTxt.text = "Money: $" + money.ToString();

        // setting up ID's for each item, first number is row, second number is column
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        shopItems[1, 7] = 7;
        shopItems[1, 8] = 8;
        shopItems[1, 9] = 9;
        shopItems[1, 10] = 10;
        shopItems[1, 11] = 11;
        shopItems[1, 12] = 12;
        shopItems[1, 13] = 13;
        shopItems[1, 14] = 14;
        shopItems[1, 15] = 15;
        shopItems[1, 16] = 16;
        shopItems[1, 17] = 17;
        shopItems[1, 18] = 18;
        shopItems[1, 19] = 19;
        shopItems[1, 20] = 20;
        shopItems[1, 21] = 21;
        shopItems[1, 22] = 22;
        shopItems[1, 23] = 23;
        shopItems[1, 24] = 24;
        shopItems[1, 25] = 25;
        shopItems[1, 26] = 26;
        shopItems[1, 27] = 27;
        shopItems[1, 28] = 28;
        shopItems[1, 29] = 29;
        shopItems[1, 30] = 30;
        shopItems[1, 31] = 31;
        shopItems[1, 32] = 32;
        shopItems[1, 33] = 33;
        shopItems[1, 34] = 34;
        shopItems[1, 35] = 35;
        shopItems[1, 36] = 36;
        shopItems[1, 37] = 37;
        shopItems[1, 38] = 38;
        shopItems[1, 39] = 39;
        shopItems[1, 40] = 40;

        // price
        shopItems[2, 1] = 2;
        shopItems[2, 2] = 3;
        shopItems[2, 3] = 3;
        shopItems[2, 4] = 2;
        shopItems[2, 5] = 1;
        shopItems[2, 6] = 6;
        shopItems[2, 7] = 3;
        shopItems[2, 8] = 2;
        shopItems[2, 9] = 4;
        shopItems[2, 10] = 4;
        shopItems[2, 11] = 3;
        shopItems[2, 12] = 2;
        shopItems[2, 13] = 3;
        shopItems[2, 14] = 5;
        shopItems[2, 15] = 4;
        shopItems[2, 16] = 8;
        shopItems[2, 17] = 3;
        shopItems[2, 18] = 7;
        shopItems[2, 19] = 3;
        shopItems[2, 20] = 3;
        shopItems[2, 21] = 2;
        shopItems[2, 22] = 3;
        shopItems[2, 23] = 3;
        shopItems[2, 24] = 4;
        shopItems[2, 25] = 3; //
        shopItems[2, 26] = 2;
        shopItems[2, 27] = 2;
        shopItems[2, 28] = 4;
        shopItems[2, 29] = 4;
        shopItems[2, 30] = 4;
        shopItems[2, 31] = 4;
        shopItems[2, 32] = 4;
        shopItems[2, 33] = 4;
        shopItems[2, 34] = 4;
        shopItems[2, 35] = 4;
        shopItems[2, 36] = 4;
        shopItems[2, 37] = 4;
        shopItems[2, 38] = 4;
        shopItems[2, 39] = 4;
        shopItems[2, 40] = 4;

        // quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
        shopItems[3, 5] = 0;
        shopItems[3, 6] = 0;
        shopItems[3, 7] = 0;
        shopItems[3, 8] = 0;
        shopItems[3, 9] = 0;
        shopItems[3, 10] = 0;
        shopItems[3, 11] = 0;
        shopItems[3, 12] = 0;
        shopItems[3, 13] = 0;
        shopItems[3, 14] = 0;
        shopItems[3, 15] = 0;
        shopItems[3, 16] = 0;
        shopItems[3, 17] = 0;
        shopItems[3, 18] = 0;
        shopItems[3, 19] = 0;
        shopItems[3, 20] = 0;
        shopItems[3, 21] = 0;
        shopItems[3, 22] = 0;
        shopItems[3, 23] = 0;
        shopItems[3, 24] = 0;
        shopItems[3, 25] = 0;
        shopItems[3, 26] = 0;
        shopItems[3, 27] = 0;
        shopItems[3, 28] = 0;
        shopItems[3, 29] = 0;
        shopItems[3, 30] = 0;
        shopItems[3, 31] = 0;
        shopItems[3, 32] = 0;
        shopItems[3, 33] = 0;
        shopItems[3, 34] = 0;
        shopItems[3, 35] = 0;
        shopItems[3, 36] = 0;
        shopItems[3, 37] = 0;
        shopItems[3, 38] = 0;
        shopItems[3, 39] = 0;
        shopItems[3, 40] = 0;
    }

    public void Buy()
    {
        GameObject buttonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

       // if (money >= shopItems[2, buttonRef.GetComponent<ButtonInfo>().itemID])
        //{
            money -= shopItems[2, buttonRef.GetComponent<ButtonInfo>().itemID];
            shopItems[3, buttonRef.GetComponent<ButtonInfo>().itemID]++;
            moneyTxt.text = "Money: $" + money.ToString();
            buttonRef.GetComponent<ButtonInfo>().quantityText.text = shopItems[3, buttonRef.GetComponent<ButtonInfo>().itemID].ToString();
       // }
    }

    public void checkPass()
    {
        if (money == 50)
        {
            SceneManager.LoadSceneAsync(12);
        }
        else if (money > 0)
        {
            SceneManager.LoadSceneAsync(4);
        }
        else
        {
            SceneManager.LoadSceneAsync(5);
        }
    }
}
