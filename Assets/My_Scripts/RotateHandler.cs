using UnityEngine;

public class RotateHandler
{
    public void RotateUp(Transform transform) =>
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0f);
    public void RotateDown(Transform transform) =>
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180f);
    public void RotateLeft(Transform transform) =>
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90f);
    public void RotateRight(Transform transform) =>
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -90f);
}
