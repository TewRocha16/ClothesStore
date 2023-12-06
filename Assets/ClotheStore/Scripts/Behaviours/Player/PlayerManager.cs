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
    private Animator animator;
    private PlayerMovementBehaviour playerMovementBehaviour;
    private PlayerInventory playerInventory;
    private int currency = 0;

    public Animator Animator { get => animator; set => animator = value; }
    public Rigidbody2D RigidBody { get => rigidBody; set => rigidBody = value; }
    public int Currency { get => currency; set => currency = value; }
    public PlayerInventory PlayerInventory { get => playerInventory; set => playerInventory = value; }

    private void Awake()
    {
        Instance = this;
        animator = GetComponentInChildren<Animator>();
        playerMovementBehaviour = GetComponent<PlayerMovementBehaviour>();
        rigidBody = GetComponent<Rigidbody2D>();
        PlayerInventory = GetComponent<PlayerInventory>();
        playerMovementBehaviour.Setup(this, animator, rigidBody);
        SetCurrency(0);
    }
    public void SetCurrency(int incomingCurrency)
    {
        currency += incomingCurrency;
        UIManager.Instance.CoinUI.text = currency.ToString();
    }
}
