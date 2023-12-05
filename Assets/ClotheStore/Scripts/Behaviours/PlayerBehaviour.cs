using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private Animator animator;
    private PlayerMovementBehaviour playerMovementBehaviour;
    public Animator Animator { get => animator; set => animator = value; }
    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        playerMovementBehaviour = GetComponent<PlayerMovementBehaviour>();
        playerMovementBehaviour.Setup(this, animator);
    }
}
