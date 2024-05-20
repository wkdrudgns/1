using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float Speed;

    Rigidbody2D rd;
    void Awake()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()//속도조절 Unity에서 Speed 10을 기본으로
    {
        Vector2 nextVec = inputVec * Speed * Time.fixedDeltaTime;
        rd.MovePosition(rd.position + nextVec);//Moveposition은 물리적 충돌이있어 사용전에 transform과 거의 동일
    }
    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }
}
