using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    [SerializeField] private Transform storeContent;
    [SerializeField] private Transform inventoryContent;
    [SerializeField] private GameObject storePrefab;
    [SerializeField] private GameObject inventoryPrefab;

    public void SetupStore(List<Item> sellerItens, List<Item> playerItens)
    {
        ClearPreviousStore();
        foreach (var storeItem in sellerItens)
        {
            GameObject localItem =  Instantiate(storePrefab, storeContent);
            localItem.GetComponent<StoreItemBehaviour>().SetupItem(storeItem, sellerItens, this);
        }
        foreach (var storeItem in playerItens)
        {
            GameObject localItem = Instantiate(inventoryPrefab, inventoryContent);
            localItem.GetComponent<InventoryItemBehaviour>().SetupItem(storeItem, sellerItens, this);
        }
    }
    private void ClearPreviousStore()
    {
        foreach (Transform child in storeContent)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in inventoryContent)
        {
            Destroy(child.gameObject);
        }
    }
}
