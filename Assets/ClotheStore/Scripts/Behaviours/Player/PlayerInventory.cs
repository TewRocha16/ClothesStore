using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private List<Item> itens;

    public List<Item> GetItens()
    {
        return itens;
    }
}
