using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// 玩家角色的刚体组件
    /// </summary>
    private Rigidbody2D rb;
    /// <summary>
    /// 玩家角色的移动速度
    /// </summary>
    public float speed;
    /// <summary>
    /// 玩家角色的炸弹倒计时
    /// </summary>
    public float bombTimer;
    /// <summary>
    /// 玩家角色的炸弹数量
    /// </summary>
    public int bombCount;
    /// <summary>
    /// 玩家角色的炸弹爆炸范围
    /// </summary>
    public float bombRadius;
    /// <summary>
    /// 玩家的X方向输入
    /// </summary>
    private float inputX;
    /// <summary>
    /// 玩家的Y方向输入
    /// </summary>
    private float inputY;
    /// <summary>
    /// 玩家的移动输入
    /// </summary>
    private Vector2 movementInput;
    
    /// <summary>
    /// 初始化
    /// </summary>
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// 每帧更新内容
    /// </summary>
    private void Update()
    {
        PlayerInput();
    }

    /// <summary>
    /// 固定帧更新内容
    /// </summary>
    private void FixedUpdate()
    {
        Movement();
    }

    /// <summary>
    /// 处理玩家的输入
    /// </summary>
    private void PlayerInput()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");

        movementInput = new Vector2(inputX, inputY);
    }

    /// <summary>
    /// 处理玩家角色的移动
    /// </summary>
    private void Movement()
    {
        rb.velocity = movementInput * speed;
    }
    
}
