using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraHoming : MonoBehaviour
{
    [SerializeField] GameObject player;
   
    private void Update()
    {
        Vector3 newPosition = transform.position; // 現在のカメラの位置を保持
        newPosition.x = player.transform.position.x; // X軸だけをプレイヤーに追従
        transform.position = newPosition; // カメラの位置を更新
    }
}
