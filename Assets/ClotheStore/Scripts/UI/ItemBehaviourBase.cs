using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class ItemBehaviourBase : MonoBehaviour
{
    [SerializeField] internal TMP_Text itemQuantity;
    [SerializeField] internal TMP_Text itemName;
    [SerializeField] internal TMP_Text value;
    [SerializeField] internal Image sprite;
    internal string description = "";
    internal int intValue = 0;
    internal AudioSource audioSource;
    [SerializeField] internal Store store;
    [SerializeField] internal List<Item> playerItens;
    [SerializeField] internal List<Item> sellerItens;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public virtual void SetupItem(string _itemName, int _value, string _description, Sprite _sprite, int quantity, List<Item> _sellerItens, Store _store)
    {
        itemName.text = _itemName;
        value.text = _value.ToString();
        intValue = _value;
        description = _description;
        sprite.sprite = _sprite;
        sellerItens = _sellerItens;
        itemQuantity.text = quantity.ToString();
        store = _store;
    }
    public virtual void SellItem()
    {
        playerItens = PlayerManager.Instance.PlayerInventory.GetItens();
    }
}
