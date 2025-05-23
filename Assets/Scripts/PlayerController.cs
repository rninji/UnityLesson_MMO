using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 10.0f;
    void Start()
    {
        Managers mg = Managers.Instance;
        Managers.Input.KeyAction -= OnKeyboard; // 중복 실행 방지
        Managers.Input.KeyAction += OnKeyboard;
    }

   void Update()
    {
        
    }

    void OnKeyboard()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), _speed * Time.deltaTime);
            transform.position += Vector3.forward *  (_speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), _speed * Time.deltaTime);
            transform.position += Vector3.left *  (_speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), _speed * Time.deltaTime);
            transform.position += Vector3.back *  (_speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), _speed * Time.deltaTime);
            transform.position += Vector3.right *  (_speed * Time.deltaTime);
        }
    }
}
