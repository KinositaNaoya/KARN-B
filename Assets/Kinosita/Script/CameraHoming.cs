using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraHoming : MonoBehaviour
{
    [SerializeField] GameObject player;//�z�[�~���O�p�ϐ�
    public Camera mainCamera;//�J�����T�C�Y�ύX�p�ϐ�

    public float now_cameraSize;        //���݂̃J�����T�C�Y��ۑ�����ϐ�
    public float init_cameraSize = 4.0f;//�J�����T�C�Y�̏����l
    public float boss_cameraSize = 8.0f;//�J�����T�C�Y��Boss�p

    //public bool cameraHoming = true;


    private void Start()
    {
        mainCamera = GetComponent<Camera>();//�����悭�킩��Ȃ��������ƃ_��
        mainCamera.orthographicSize = init_cameraSize;//�J�����T�C�Y�̏����ݒ�
    }
    private void Update()
    {
        now_cameraSize = mainCamera.orthographicSize;//���̃J�����T�C�Y�̒l���擾��������B
        Vector3 nowPosition = transform.position; // ���݂̃J�����̈ʒu��ێ�

        //�Q�[���I�u�W�F�N�g"BossArea.inArea"�̏�Ԃɉ���������
        if (GameObject.Find("BossArea").GetComponent<BossArea>().inArea == true )
        {   //�{�X��Ԃ̃J��������

            if (mainCamera.orthographicSize != boss_cameraSize)
            {   //�J�������{�X��ԗp�ɕω�����

                if (now_cameraSize <= boss_cameraSize)
                {   //�T�C�Y�ω�
                    mainCamera.orthographicSize += 0.01f;
                }
            }
        }
        else if(GameObject.Find("BossArea").GetComponent<BossArea>().inArea == false )
        {   //�ʏ��Ԃ̃J�����̏���

            
            if(mainCamera.orthographicSize != init_cameraSize)
            {   //�J������ʏ��ԗp�ɕω�����

                if (now_cameraSize >= init_cameraSize)
                {   //�T�C�Y�ω�
                    mainCamera.orthographicSize -= 0.01f;
                }
            }


            nowPosition.x = player.transform.position.x; // X���������v���C���[�ɒǏ]

            //==�Ǐ]����==
            //if (nowPosition.x == player.transform.position.x)
            //{
            //    nowPosition.x = player.transform.position.x; // X���������v���C���[�ɒǏ]
            //    cameraHoming =false;
            //}

            //if (cameraHoming==true)
            //{
            //    if(nowPosition.x >= player.transform.position.x)
            //    {
            //        nowPosition.x -= 0.01f;
            //    }
            //    else if(nowPosition.x <= player.transform.position.x)
            //    {
            //        nowPosition.x += 0.01f;
            //    }
            //}
            
            transform.position = nowPosition; // �J�����̈ʒu���X�V
        }
    }
}
