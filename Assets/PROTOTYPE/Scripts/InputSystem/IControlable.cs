using UnityEngine;

public interface IControlable
{
    void Move(Vector3 direction);
    void Jump();
}