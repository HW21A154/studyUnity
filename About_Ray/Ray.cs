using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ray : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
 
            if (Input.GetMouseButtonDown(0)) 
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                //RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
                
                //2DのゲームでカメラのプロジェクションをPerspectiveにした場合
                RaycastHit2D hit2d = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
                //デバッグ用のレイの描画
                //Debug.DrawRay(ray.origin, ray.direction * 30, Color.red, 20f);
                if (hit2d)
                {
                    Debug.Log("true");
                }
            }
    }
}