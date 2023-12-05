using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private Animator animator;
    private PlayerMovementBehaviour playerMovementBehaviour;
    public Animator Animator { get => animator; set => animator = value; }
    public Rigidbody2D RigidBody { get => rigidBody; set => rigidBody = value; }

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        playerMovementBehaviour = GetComponent<PlayerMovementBehaviour>();
        rigidBody = GetComponent<Rigidbody2D>();
        playerMovementBehaviour.Setup(this, animator, rigidBody);
    }
}
