
using UnityEngine;

public class DesktopMovement : IInputSystem
{
    public float Speed => 5f;


    public void HorizontalMovement(Transform transform, float Speed)
    {
        float h = Input.GetAxis("Horizontal");
        transform.Translate(h * Speed * Time.deltaTime, 0f, 0f);
    }

    public void VerticalMovement(Transform transform, float Speed)
    {
        float v = Input.GetAxis("Vertical");
        transform.Translate(0f, v * Speed * Time.deltaTime, 0f);
    }
}
