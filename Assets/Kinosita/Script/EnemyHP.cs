using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] int HP;//�G��HP

    void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)//���ݒu
    {
        if (collision.gameObject.name =="AttckPoint")//��A�l�[���ł͂Ȃ�Tag�ŊǗ����ׂ��B
        {
            //AttckPoint����U���͂̕ϐ����擾���Čv�Z������(�\��)
            Debug.Log("-1");
            HP -= 1;
        }
    }
}
