using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class playreControl : MonoBehaviour
{
    //�ϐ��錾
    public float movespeed = 3;//�ړ����x
    float leftcoolTime = 0;//�N�[���^�C��(��r�p)
    float coolTime = 0.5f;//�N�[���^�C��(�Œ�l)
    [SerializeField] public GameObject attckpoint;

    new Rigidbody2D rigidbody2D;
    Animator animator;

    void Start()
    {
        //�R���|�[�l���g�̎擾
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        leftcoolTime -= Time.deltaTime;

        if (leftcoolTime <= 0)
        {
            MoveUpdeta();
            JumpUpdeta();
            AttackUpdeta();
        }
    }

    private void MoveUpdeta()//�L�����N�^�[�̈ړ��֐�
    {
        //�L�[����(���͂��������ꍇ�{�f�B�[�ɌŒ��velosity�����������Ă���B)
        if (Input.GetKey(KeyCode.D))
        {
            
            transform.localScale = new Vector3(-1,1,1);
            rigidbody2D.velocity = new Vector2(1 * movespeed, rigidbody2D.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(1, 1, 1);
            rigidbody2D.velocity = new Vector2(-1 * movespeed, rigidbody2D.velocity.y);
        }

        //�A�j���[�V����(GetKey��bool��if�œǂݎ���Ă���B)
        if(Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.A)==true) 
        {
            animator.SetBool("Rum", true); 
        }else
        {
            animator.SetBool("Rum", false);

            //���ꂪ�Ȃ��Ɗ����Ă���
            rigidbody2D.velocity = new Vector2(0,rigidbody2D.velocity.y) ;
        }
        

    }

    private void JumpUpdeta()//�L�����N�^�[�̃W�����v�֐�
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            float jumpPower = 6.0f;

            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpPower);
        }
    }

    private void AttackUpdeta()//�L�����N�^�[�̍U���֐�
    {
            if (Input.GetMouseButton(0))
            {
                rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
                animator.SetBool("Rum", false);
                animator.SetTrigger("Attack");
                leftcoolTime = coolTime;
                StartCoroutine("Deley");

                
            }
    }
    IEnumerator  Deley() //�U���̓��ݍ��݂��f�B���C������֐�
    {
        yield return new WaitForSeconds(0.3f);
        //�����Ɏq�I�u�W�F�̐^�U�؂�ւ�������
        attckpoint.SetActive(true);
        Vector3 pos = transform.localScale;
        if (pos.x == -1)
        {
            rigidbody2D.velocity = new Vector2(2 * movespeed, rigidbody2D.velocity.y);
        }
        else if (pos.x == 1)
        {
            rigidbody2D.velocity = new Vector2(-2 * movespeed, rigidbody2D.velocity.y);
        }
        yield return new WaitForSeconds(0.2f);
        rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
        attckpoint.SetActive(false);
        leftcoolTime = coolTime;

    }
}
