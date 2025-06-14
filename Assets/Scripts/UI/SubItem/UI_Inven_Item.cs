using TMPro;
using UnityEngine;

public class UI_Inven_Item : UI_Base
{
    private string _name;
    enum GameObjects
    {
        ItemIcon,
        ItemNameText,
    }
    void Start()
    {
        Init();
    }

    public override void Init()
    {
        Bind<GameObject>(typeof(GameObjects));
        Get<GameObject>((int)GameObjects.ItemNameText).GetComponent<TMP_Text>().text = _name;
        
        Get<GameObject>((int)GameObjects.ItemIcon).AddUIEvent((PointerEventData) => { Debug.Log($"아이템 클릭! {_name}"); });
    }

    public void SetInfo(string name)
    {
        _name = name;
    }
}
