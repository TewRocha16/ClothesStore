using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemBehaviour : ItemBehaviourBase
{
    [SerializeField] AudioClip sellSound;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public override void SetupItem(string _itemName, int _value, string _description, Sprite _sprite, int quantity, List<Item> _sellerItens, Store _store)
    {
        base.SetupItem(_itemName, _value, _description, _sprite, quantity, _sellerItens, _store);
        if (quantity == 0)
            gameObject.SetActive(false);
    }
    public override void SellItem()
    {
        base.SellItem();
        foreach (Item item in playerItens)
        {
            if (itemName.text == item.item.itemName)
            {
                item.quantity -= 1;
                itemQuantity.text = item.quantity.ToString();
                audioSource.clip = sellSound;
                audioSource.Play();
                PlayerManager.Instance.SetCurrency(intValue);
                if (item.quantity == 0)
                    gameObject.SetActive(false);
            }
        }
        foreach (Item item in sellerItens)
        {
            if (itemName.text == item.item.itemName)
                item.quantity += 1;
        }
        store.SetupStore(sellerItens,playerItens);
    }
}
