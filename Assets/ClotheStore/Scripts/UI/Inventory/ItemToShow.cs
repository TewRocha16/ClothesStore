using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemToShow : MonoBehaviour
{
    [SerializeField] private UnityEvent action;
    [SerializeField] Image itemImage;
    [SerializeField] TMP_Text itemName;
    private Item item;
    public void SetupItem(Item _item)
    {
        item = _item;
        itemImage.sprite = item.item.sprite;
        itemName.text = item.item.itemName;
        if (item.quantity == 0)
        {
            gameObject.SetActive(false);
        }
    }
    public void OpenModal()
    {
        UIManager.Instance.ConfirmationModal.modalGameObject.SetActive(true);
        UIManager.Instance.ConfirmationModal.Setup(item.item.itemName, item.item.description, action, "Equip");
    }
    public void UseItem()
    {
        PlayerManager.Instance.ClothesManager.SetupNewCloth(item.item.itemName);
        UIManager.Instance.Inventory.inventoryGameObject.SetActive(false);
    }
}
