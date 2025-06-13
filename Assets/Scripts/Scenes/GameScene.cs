using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    protected override void Init()
    {
        base.Init();
        
        SceneType = Define.Scene.Game;
        Managers.UI.ShowSceneUI<UI_Inven>();
        
        for (int i = 0; i < 5; i++)
            Managers.Resource.Instantiate("UnityChan");

        Dictionary<int, Stat> stats = Managers.Data.StatDict;
    }

    public override void Clear()
    {
        throw new System.NotImplementedException();
    }
    
}
