using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using static UnityEditor.Progress;

public abstract class ItemBehaviourBase : MonoBehaviour
{
    [SerializeField] internal string buttonName;
    [SerializeField] internal TMP_Text itemQuantity;
    [SerializeField] internal TMP_Text itemName;
    [SerializeField] internal TMP_Text value;
    [SerializeField] internal Image sprite;
    [SerializeField] private UnityEvent action;
    internal string description = "";
    internal int intValue = 0;
    internal AudioSource audioSource;
    internal Store store;
    internal List<Item> playerItens;
    internal List<Item> sellerItens;
    internal Item itemSelected;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public virtual void SetupItem(Item _item, List<Item> _sellerItens, Store _store)
    {
        itemSelected = _item;
        itemName.text = itemSelected.item.itemName;
        value.text = itemSelected.item.price.ToString();
        intValue = itemSelected.item.price;
        description = itemSelected.item.description;
        sprite.sprite = itemSelected.item.sprite;
        sellerItens = _sellerItens;
        itemQuantity.text = itemSelected.quantity.ToString();
        store = _store;
    }
    public virtual void SellItem()
    {
        playerItens = PlayerManager.Instance.PlayerInventory.GetItens();
    }
    public void OpenModal()
    {
        UIManager.Instance.ConfirmationModal.modalGameObject.SetActive(true);
        UIManager.Instance.ConfirmationModal.Setup(itemSelected.item.itemName, itemSelected.item.description, action, buttonName);
    }
}
