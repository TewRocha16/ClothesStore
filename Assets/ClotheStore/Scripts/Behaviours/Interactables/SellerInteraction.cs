using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SellerInteraction : InteractionBase
{
    [SerializeField] private List<Item> sellerItens;
    [SerializeField] private AudioClip openSellerClip;
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
        SoundManager.PlaySound(openSellerClip);
        var playerItens = PlayerManager.Instance.PlayerInventory.GetItens();
        UIManager.Instance.Store.gameObject.SetActive(true);
        UIManager.Instance.Store.SetupStore(sellerItens, playerItens);
    }
    public void CloseStoreUI()
    {
        SoundManager.PlaySound(openSellerClip);
        UIManager.Instance.Store.gameObject.SetActive(false);
    }
}
