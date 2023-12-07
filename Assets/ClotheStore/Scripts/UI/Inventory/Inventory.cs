using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject itemPrefab;
    [SerializeField] Transform contentUI;
    public GameObject inventoryGameObject;
    public void Setup()
    {
        inventoryGameObject.SetActive(true);
        ClearPreviousStore();
        foreach (var playerItem in PlayerManager.Instance.PlayerInventory.GetItens())
        {
            GameObject localItem = Instantiate(itemPrefab, contentUI);
            localItem.GetComponent<ItemToShow>().SetupItem(playerItem);
        }
    }
    private void ClearPreviousStore()
    {
        foreach (Transform child in contentUI)
        {
            Destroy(child.gameObject);
        }
    }
}
