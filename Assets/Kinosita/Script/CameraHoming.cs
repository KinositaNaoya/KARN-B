using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraHoming : MonoBehaviour
{
    [SerializeField] GameObject player;
   
    private void Update()
    {
        Vector3 newPosition = transform.position; // ���݂̃J�����̈ʒu��ێ�
        newPosition.x = player.transform.position.x; // X���������v���C���[�ɒǏ]
        transform.position = newPosition; // �J�����̈ʒu���X�V
    }
}
