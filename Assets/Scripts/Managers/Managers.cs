using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; // 유일성 보장
    static public Managers Instance
    {
        get { Init(); return s_instance; }
    } // 유일한 매니저를 가져옴
    
    InputManager _input = new InputManager();
    static public InputManager Input
    {
        get { return Instance._input; }
    }
    void Start()
    {
        Init();
    }

    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject("@Managers");
                go.AddComponent<Managers>();
            }
           
            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }
    }
}
