using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime; // �̵��ӵ� ����
       
    }

    public void MoveTo(Vector3 _Dir)
    {
        moveDirection = _Dir; 


    }

    //����

    [SerializeField]
    private float moveSpeed = 0.0f;

    [SerializeField]
    private Vector3 moveDirection = Vector3.zero;

    public float MoveSpeed => moveSpeed; //���� �����̴� �ӵ��� ���� �ӵ��� ���� ���ų� ������� 


}
