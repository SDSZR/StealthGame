using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpTools : MonoBehaviour
{
    public List<Transform> child = new List<Transform>();
    /// <summary>
    /// 得到当前服务体全部子物体功能
    /// </summary>
    /// <param name="transPrant">要查询的父物体</param>
    public void FindAllTransform(Transform transPrant)
    {
        if (transPrant.childCount > 0)
        {
            for (int i = 0; i < transPrant.childCount; i++)
            {
                FindAllTransform(transPrant.GetChild(i));
            }
        }
        if (!child.Contains(transPrant))
        {
            child.Add(transPrant);
        }
        else
        {
            Debug.LogError(transPrant.name + "-名称重复！！");
        }
    }
}
