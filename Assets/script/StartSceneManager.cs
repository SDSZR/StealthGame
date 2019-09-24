/*
 * 开始场景管理脚本
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneManager : HelpTools
{
    #region StartSceneBtn

    public Button _ShowInfoCloseBtn;
    public Button _ShowInfoBtn;

    public Button _btnNewGame;
    public Button _btnReStartGame;
    #endregion

    #region Mono
    // Use this for initialization
    void Start()
    {
        FindAllTransform(this.transform);
        
        _ShowInfoCloseBtn.onClick.AddListener(OnClickClose);
        _ShowInfoBtn.onClick.AddListener(OnClickShowInfo);

        _btnNewGame.onClick.AddListener(OnClickNewGameBtn);
        _btnReStartGame.onClick.AddListener(OnClickReStartBtn);
    }

    private void OnClickReStartBtn()
    {
        
    }

    private void OnClickNewGameBtn()
    {
        SceneManager.LoadScene("MainScene");
    }

    private void OnClickShowInfo()
    {
        UIManager.uiManagerInstate.OnClickUIOpenBtn(this["ima_AuthorInfo"]);
    }

    private void OnClickClose()
    {
        UIManager.uiManagerInstate.OnClickUICloseBtn(this["ima_AuthorInfo"]);
    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion

    Transform this[string name]
    {
        get { return child.Find((x) => x.name == name); }
    }
}
