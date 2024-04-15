using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//命名空间
public class LunaController : MonoBehaviour//继承monobehaviour实现基本的方法，monibehaviour不是接口，接口所有功能都必须被实现
{
    private Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()//游戏开始调用
    {
        //Application.targetFrameRate = 30;//帧率修改为10
        rigidbody2d = GetComponent<Rigidbody2D>();//定义一个容器获取右边的值，getcomponent是获取组件，填名字或类型
        //含义是调用方法的
        
    }

    // Update is called once per frame
    void Update()//游戏每一帧都会调用
    {
        //获取玩家水平轴输入值
        float horizontal = Input.GetAxis("Horizontal");
        //获取玩家垂直轴向输入值
        float vertical = Input.GetAxis("Vertical");
        //移动一般放在update中
        Vector2 pos = transform.position;
        pos.x = pos.x + 30f * horizontal*Time.deltaTime;
        pos.y = pos.y + 30f * vertical*Time.deltaTime;
        // transform.position = pos;
        rigidbody2d.MovePosition(pos);
    }
}
