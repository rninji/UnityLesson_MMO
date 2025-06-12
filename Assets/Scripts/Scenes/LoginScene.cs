using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginScene : BaseScene
{
    protected override void Init(){
        base.Init();
        SceneType = Define.Scene.Login;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            Managers.Scene.LoadScene(Define.Scene.Game);
    }

    public override void Clear()
    {
        UnityEngine.Debug.Log("LoginScene Clear");
    }
}
