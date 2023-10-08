using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    // 刚体组件
    public Rigidbody2D rbComponent;
    // Sprite Renderer 组件
    public SpriteRenderer spriteRenderer;
    // 输入控制器
    private PlayerInputControl inputControl;
    // 移动方向
    public Vector2 inputDirection;
    // 移动速度
    public float Speed;
    private void Awake()
    {
        inputControl = new PlayerInputControl();
    }
    private void OnEnable()
    {
        inputControl.Enable();
    }
    private void OnDisable()
    {
        inputControl.Disable();
    }
    private void Update()
    {
        inputDirection = inputControl.Gameplay.Move.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        Move();
    }
    /**
     * 处理人物移动
     */
    private void Move()
    {
        // 控制人物移动速度
        rbComponent.velocity = new Vector2(inputDirection.x * Speed * Time.deltaTime, rbComponent.velocity.y);
        //计算人物水平翻转的方向
        if (inputDirection.x != 0)
        {
            spriteRenderer.flipX = inputDirection.x > 0;
        }
    }
}
