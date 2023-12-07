using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemBehaviour : ItemBehaviourBase
{
    [SerializeField] Cloth defaultCloth;
    [SerializeField] AudioClip sellSound;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public override void SetupItem(Item _item, List<Item> _sellerItens, Store _store)
    {
        base.SetupItem(_item, _sellerItens, _store);
        if (_item.item.itemName == "Unnequip")
            gameObject.SetActive(false);
        if (itemSelected.quantity == 0)
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
                SoundManager.PlaySound(sellSound);
                PlayerManager.Instance.SetCurrency(intValue);
                if (item.quantity == 0)
                {
                    gameObject.SetActive(false);
                    if (PlayerManager.Instance.ClothesManager.ActualCloth != null)
                    {
                        if (PlayerManager.Instance.ClothesManager.ActualCloth.clothName == item.item.itemName)
                            PlayerManager.Instance.ClothesManager.SetupNewCloth(defaultCloth.clothName);
                    }
                }
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
