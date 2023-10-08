using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rbComponent;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        rbComponent = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        SetAnimation();
    }
    public void SetAnimation()
    {
        anim.SetFloat("velocityX", Math.Abs(rbComponent.velocity.x));
    }
}
