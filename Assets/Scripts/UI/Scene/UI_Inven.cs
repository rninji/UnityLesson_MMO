using UnityEngine;

public class UI_Inven : UI_Scene
{
    enum GameObjects
    {
        GridPanel,
    }

    void Start()
    {
        Init();
    }

    public override void Init()
    {
        base.Init();
        Bind<GameObject>(typeof(GameObjects));
        
        GameObject gridPanel = Get<GameObject>((int)GameObjects.GridPanel);
        // 자식 요소 제거
        foreach(Transform child in gridPanel.transform)
            Managers.Resource.Destroy(child.gameObject);
        
        // 실제 인벤토리 정보를 참고
        for (int i = 0; i < 8; i++)
        {
            UI_Inven_Item item = Managers.UI.MakeSubItem<UI_Inven_Item>(parent: gridPanel.transform);
            item.SetInfo($"Gun{i}");
        }
    }
}
