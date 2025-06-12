using UnityEngine;

public class Test : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioClip audioClip2;
    
    void OnTriggerEnter(Collider collision)
    {
        Managers.Sound.Play( audioClip);
        Managers.Sound.Play( audioClip2, Define.Sound.Bgm);
    }
}
