using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    private PlayerManager playerBehaviour;
    private Rigidbody2D rigidBody;
    private Animator animator;
    [Header("Movement Configs")]
    [SerializeField] private float speed;
    private float lastXInput = 0;
    private float lastYInput = 0;
    public void Setup(PlayerManager behaviour, Animator anim, Rigidbody2D rb)
    {
        playerBehaviour = behaviour;
        animator = anim;
        rigidBody = rb;
    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");

        if (yInput != 0)
        {
            lastXInput = 0;
            lastYInput = yInput;
        }
        if (xInput != 0)
        {
            lastYInput = 0;
            lastXInput = xInput;
        }

        Vector2 direction = new Vector2 (xInput, yInput);

        animator.SetFloat("xInput", xInput);
        animator.SetFloat("yInput", yInput);
        animator.SetFloat("lastXDirection", lastXInput);
        animator.SetFloat("lastYDirection", lastYInput);
        animator.SetFloat("speed", direction.magnitude);

        rigidBody.MovePosition(rigidBody.position + direction.normalized * speed*Time.deltaTime);

        //transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
