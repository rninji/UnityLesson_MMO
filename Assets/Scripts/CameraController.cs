using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _player = null;
    [SerializeField] private Vector3 _delta = new Vector3(0, 6.0f, -5.0f);

    private Define.CameraMode _mode;
    void Start()
    {
        
    }

    void LateUpdate()
    {
        if (_mode == Define.CameraMode.QuaterView)
        {
            RaycastHit hit;
            if (Physics.Raycast(_player.transform.position, _delta, out hit, _delta.magnitude,
                    LayerMask.GetMask("Wall")))
            {
                // 벽과 충돌 시 카메라 줌인
                float dist = (hit.point - _player.transform.position).magnitude * 0.8f;
                transform.position = _player.transform.position + _delta.normalized * dist;
            }
            else
            {
                // 플레이어 따라 이동
                transform.position = _player.transform.position + _delta;
                transform.LookAt(_player.transform);
            }
        }
        
    }

    public void SetQuaterView(Vector3 delta)
    {
        _mode = Define.CameraMode.QuaterView;
        _delta = delta;
    }
}
