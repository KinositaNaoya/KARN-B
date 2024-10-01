using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraHoming : MonoBehaviour
{
    [SerializeField] GameObject player;//ホーミング用変数
    public Camera mainCamera;//カメラサイズ変更用変数

    public float now_cameraSize;        //現在のカメラサイズを保存する変数
    public float init_cameraSize = 4.0f;//カメラサイズの初期値
    public float boss_cameraSize = 8.0f;//カメラサイズのBoss用

    //public bool cameraHoming = true;


    private void Start()
    {
        mainCamera = GetComponent<Camera>();//何かよくわからないが無いとダメ
        mainCamera.orthographicSize = init_cameraSize;//カメラサイズの初期設定
    }
    private void Update()
    {
        now_cameraSize = mainCamera.orthographicSize;//今のカメラサイズの値を取得し続ける。
        Vector3 nowPosition = transform.position; // 現在のカメラの位置を保持

        //ゲームオブジェクト"BossArea.inArea"の状態に応じた処理
        if (GameObject.Find("BossArea").GetComponent<BossArea>().inArea == true )
        {   //ボス状態のカメラ処理

            if (mainCamera.orthographicSize != boss_cameraSize)
            {   //カメラをボス状態用に変化処理

                if (now_cameraSize <= boss_cameraSize)
                {   //サイズ変化
                    mainCamera.orthographicSize += 0.01f;
                }
            }
        }
        else if(GameObject.Find("BossArea").GetComponent<BossArea>().inArea == false )
        {   //通常状態のカメラの処理

            
            if(mainCamera.orthographicSize != init_cameraSize)
            {   //カメラを通常状態用に変化処理

                if (now_cameraSize >= init_cameraSize)
                {   //サイズ変化
                    mainCamera.orthographicSize -= 0.01f;
                }
            }


            nowPosition.x = player.transform.position.x; // X軸だけをプレイヤーに追従

            //==追従処理==
            //if (nowPosition.x == player.transform.position.x)
            //{
            //    nowPosition.x = player.transform.position.x; // X軸だけをプレイヤーに追従
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
            
            transform.position = nowPosition; // カメラの位置を更新
        }
    }
}
