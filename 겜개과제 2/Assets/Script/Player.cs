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
    private void FixedUpdate()//�ӵ����� Unity���� Speed 10�� �⺻����
    {
        Vector2 nextVec = inputVec * Speed * Time.fixedDeltaTime;
        rd.MovePosition(rd.position + nextVec);//Moveposition�� ������ �浹���־� ������� transform�� ���� ����
    }
    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }
}
