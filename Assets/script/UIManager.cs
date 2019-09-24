/*
 * UI管理脚本
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager uiManagerInstate;

    private void Awake()
    {
        uiManagerInstate = this;
    }


    public void OnClickUICloseBtn(Transform tans)
    {
        tans.localScale = Vector3.zero;
    }
    public void OnClickUIOpenBtn(Transform tans)
    {
        tans.localScale = Vector3.one;
    }
}
