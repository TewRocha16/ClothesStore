using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    private PlayerBehaviour playerBehaviour;
    private Animator animator;
    [Header("Movement Configs")]
    [SerializeField] private float speed;
    private float lastXInput = 0;
    private float lastYInput = 0;
    public void Setup(PlayerBehaviour behaviour, Animator anim)
    {
        playerBehaviour = behaviour;
        animator = anim;
    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");

        if (xInput != 0)
        {
            lastYInput = 0;
            lastXInput = xInput;
        }
        if (yInput != 0)
        {
            lastXInput = 0;
            lastYInput = yInput;
        }

        Vector3 direction = new Vector3 (xInput, yInput, 0);

        animator.SetFloat("xInput", xInput);
        animator.SetFloat("yInput", yInput);
        animator.SetFloat("lastXDirection", lastXInput);
        animator.SetFloat("lastYDirection", lastYInput);
        animator.SetFloat("speed", direction.magnitude);

        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
