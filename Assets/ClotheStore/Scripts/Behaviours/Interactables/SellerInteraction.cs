using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SellerInteraction : InteractionBase
{
    [SerializeField] private List<Item> sellerItens;
    public override void Interact()
    {
        OpenStoreUI();
    }
    public override void EndInteraction()
    {
        CloseStoreUI();
    }
    public void OpenStoreUI()
    {
        var playerItens = PlayerManager.Instance.PlayerInventory.GetItens();
        UIManager.Instance.Store.gameObject.SetActive(true);
        UIManager.Instance.Store.SetupStore(sellerItens, playerItens);
    }
    public void CloseStoreUI()
    {
        UIManager.Instance.Store.gameObject.SetActive(false);
    }
}
