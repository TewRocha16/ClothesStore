using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoreItemBehaviour : ItemBehaviourBase
{
    [SerializeField] GameObject souldOut;
    [SerializeField] AudioClip withoutMoneySound;
    [SerializeField] AudioClip purchase;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public override void SetupItem(Item _item, List<Item> _sellerItens, Store _store)
    {
        base.SetupItem(_item, _sellerItens, _store);
        if (PlayerManager.Instance.GetCurrency() < itemSelected.item.price)
            value.color = Color.red;
        if (itemSelected.quantity == 0) 
            souldOut.SetActive(true);
        else
            souldOut.SetActive(false);
    }
    public override void SellItem()
    {
        base.SellItem();
        if (PlayerManager.Instance.GetCurrency() >= intValue)
        {
            foreach (var item in sellerItens)
            {
                if (itemName.text == item.item.itemName)
                {
                    item.quantity -= 1;
                    if (item.quantity == 0)
                        souldOut.SetActive(true);
                    else
                        souldOut.SetActive(false);
                    audioSource.clip = purchase;
                    audioSource.Play();
                    PlayerManager.Instance.SetCurrency(-intValue);
                }
            }
            foreach (var item in playerItens)
            {
                if (itemName.text == item.item.itemName)
                    item.quantity += 1;
            }
            store.SetupStore(sellerItens,playerItens);
        }
        else
        {
            value.gameObject.GetComponent<Animator>().SetTrigger("trig");
            audioSource.clip = withoutMoneySound;
            audioSource.Play();
        }
    }
}
