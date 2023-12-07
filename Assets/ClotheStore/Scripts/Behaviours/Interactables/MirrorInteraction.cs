using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorInteraction : InteractionBase
{
    public override void Interact()
    {
        OpenChangeClothesUI();
    }
    public override void EndInteraction()
    {
        UIManager.Instance.Inventory.inventoryGameObject.SetActive(false);
    }
    public void OpenChangeClothesUI()
    {
        UIManager.Instance.Inventory.Setup();
    }
}
