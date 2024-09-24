using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime; // 이동속도 관련
       
    }

    public void MoveTo(Vector3 _Dir)
    {
        moveDirection = _Dir; 


    }

    //변수

    [SerializeField]
    private float moveSpeed = 0.0f;

    [SerializeField]
    private Vector3 moveDirection = Vector3.zero;

    public float MoveSpeed => moveSpeed; //실제 움직이는 속도는 지금 속도에 비해 같거나 빨라야함 


}
