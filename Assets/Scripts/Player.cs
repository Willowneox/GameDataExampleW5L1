using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // when this stores a list of InventoryItems, it won't show up in the Inspector
    // if it stores a list of Items, you have to create GameObjects for each item
    //
    // but what if these items never appear on-screen, or appear and disappear in UI?
    // does it make sense for Item to be a MonoBehaviour if it's only representing data and not behavior?
    [SerializeField] private List<InventoryItem> _inventory;
}

public class InventoryItem {
    public string name;
}