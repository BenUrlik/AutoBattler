using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public static List<Character> BuyOptions;
    public static float Money;
    public bool Locker;

    void Start() {
        Money = 10;
        // refreshShop();
        Locker = false;
    }

    public void Buy(Character Unit) {
        // Add character to the field
        // getCharCount(unit)
        // Subtract coins from the players bank
        // Removes the character from the shop
        Debug.Log("buy");
    }

    public void Sell() {
        // On click and drag to trash
        // Destroy Game Object
        // Add cash to the players bank
    }

    public void RefreshShop() {
        for(int i = 0; i < 3; ++i) {
            BuyOptions.Clear();
            // buyOptions.Add(new Character);
        }
    }

    public void LockShop() {
        Locker = true;
        // Should lock the shop options till next purchasePhase
    }
}
