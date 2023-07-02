using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 startPos;
    private bool isJump;
    private Animator animator;

    void Start()
    {
        startPos = transform.position;
        animator = GetComponentInChildren<Animator> ();
        isJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool ("isRunning", true);
    }
}
