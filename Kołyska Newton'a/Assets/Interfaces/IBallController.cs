using UnityEngine;

public interface IBallController
{
    Vector3 GetMouseAsWorldPoint();
    void OnMouseDown();
}