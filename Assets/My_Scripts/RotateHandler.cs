using UnityEngine;

public class RotateHandler : MonoBehaviour
{
    private void Update()
    {
        if (Mathf.Abs(transform.position.x) > 0.1f)
        {
            Quaternion.Euler(0f, 0f, 90f);
        }
    }
}
