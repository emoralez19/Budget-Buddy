using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class PlayerInteract : MonoBehaviour
{
    public GameObject cam;

    public PlayerMoney money;
    void Start()
    {
        money = GetComponent<PlayerMoney>();
    }

   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("interObj"))
        {
            Debug.Log(other.name);
            money.SubtractMoney(4);
            Destroy(gameObject);
            // currentInterObj = other.gameObject;
            //cam.GetComponent<PlayerMoney>().SubtractMoney(4);
            
        }
    }

   /* void Pickup()
    {
        // Inventory.AddItem(item);
        Destroy(gameObject);
    }
}
*/