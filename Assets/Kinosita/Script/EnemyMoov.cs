using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoov : MonoBehaviour
{
    [SerializeField] GameObject playerPos;
    [SerializeField] float movespeed;

    new Rigidbody2D rigidbody2D;
    Vector3 mypos;
    Vector3 targetpos;

    int pos;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        mypos = transform.position;//�����̈ʒu
        targetpos = playerPos.transform.position;//�^�[�Q�b�g�̈ʒu
        if ((mypos.x - targetpos.x) <= 0)
        {
            pos = 1;
        }
        else
        {
            pos = -1;
        }


        rigidbody2D.velocity = new Vector2(pos * movespeed, rigidbody2D.velocity.y);
    }
}
