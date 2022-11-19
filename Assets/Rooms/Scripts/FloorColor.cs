using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ChangeFloorColor : MonoBehaviour 
{
    private MeshRenderer msRender;
    private float smooth = 0.5f;
 
	void Start () {
        msRender = GetComponent<MeshRenderer>();
 
        // 设置物体的初始颜色
        msRender.material.color = Color.blue;
	}
	
	void Update () {
        // 通过线性插值的方式来逐渐改变物体的颜色
        msRender.material.color = Color.Lerp(msRender.material.color, Color.red, smooth * Time.deltaTime);
    }
}

