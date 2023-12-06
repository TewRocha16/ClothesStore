using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "StoreItem", menuName = "ScriptableObjects/StoreItem")]
public class StoreItem : ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite sprite;
    public int price;
}
