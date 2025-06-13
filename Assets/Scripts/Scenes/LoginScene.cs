using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginScene : BaseScene
{
    protected override void Init(){
        base.Init();
        SceneType = Define.Scene.Login;

        List<GameObject> list = new List<GameObject>(); 
        for (int i = 0; i < 2; i++)
            list.Add(Managers.Resource.Instantiate("UnityChan"));
        
        foreach (GameObject go in list)
            Managers.Resource.Destroy(go);
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
