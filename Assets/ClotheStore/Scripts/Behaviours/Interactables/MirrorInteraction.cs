using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorInteraction : InteractionBase
{
    [SerializeField] private AudioClip openMenuClip;
    public override void Interact()
    {
        OpenChangeClothesUI();
    }
    public override void EndInteraction()
    {
        SoundManager.PlaySound(openMenuClip);
        UIManager.Instance.Inventory.inventoryGameObject.SetActive(false);
    }
    public void OpenChangeClothesUI()
    {
        SoundManager.PlaySound(openMenuClip);
        UIManager.Instance.Inventory.Setup();
    }
}
