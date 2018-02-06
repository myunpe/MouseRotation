using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{



    //回転用
    Vector2 sPos;   //タッチした座標
    Quaternion sRot;//タッチしたときの回転
    float wid, hei, diag;  //スクリーンサイズ
    float tx, ty;    //変数

    float rate = 1.0f;
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            TouchBegan();
        }
        else if (Input.GetMouseButton(0))
        {
            TouchMoved();
        }


    }
    void TouchBegan()
    {
        sPos = Input.mousePosition;
        sRot = gameObject.transform.rotation;
    }
    void TouchMoved()
    {
        tx = (Input.mousePosition.x - sPos.x) / Screen.width * rate; //横移動量
        ty = (Input.mousePosition.y - sPos.y) / Screen.height * rate; //縦移動量
        gameObject.transform.rotation = sRot;

        gameObject.transform.Rotate(new Vector3(90 * ty, 0f, 0), Space.World);
        gameObject.transform.Rotate(new Vector3(0f, -90 * tx, 0), Space.Self);
    }


}
