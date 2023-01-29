using UnityEngine;

public class TPFCamera : MonoBehaviour, IMovable
{
    private Transform _tpfCameraTransform;


    private void Awake()
    {
        _tpfCameraTransform = Camera.main.transform;
    }

    public void Move(Vector3 direction)
    {
        Vector3 move = _tpfCameraTransform.forward * direction.z + _tpfCameraTransform.forward * direction.x;
    }
}
