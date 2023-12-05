using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;
    private Rigidbody2D rigidBody;
    private Animator playerAnimator;
    private PlayerMovementBehaviour playerMovementBehaviour;
    private PlayerInventory playerInventory;
    private int currency = 0;
    private ClothesManager clothesManager;
    public Rigidbody2D RigidBody { get => rigidBody; set => rigidBody = value; }
    public PlayerInventory PlayerInventory { get => playerInventory; set => playerInventory = value; }
    public ClothesManager ClothesManager { get => clothesManager; set => clothesManager = value; }

    private void Awake()
    {
        Instance = this;
        playerAnimator = GetComponentInChildren<Animator>();
        playerMovementBehaviour = GetComponent<PlayerMovementBehaviour>();
        rigidBody = GetComponent<Rigidbody2D>();
        PlayerInventory = GetComponent<PlayerInventory>();
        ClothesManager = GetComponent<ClothesManager>();
        playerMovementBehaviour.Setup(this, playerAnimator, rigidBody);
    }
    public int GetCurrency()
    {
        return currency;
    }
    public void SetCurrency(int incomingCurrency)
    {
        currency += incomingCurrency;
        UIManager.Instance.CoinUI.text = currency.ToString();
    }
}
