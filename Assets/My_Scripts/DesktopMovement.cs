
using UnityEngine;

public class DesktopMovement : IInputSystem
{
    public float Speed => 5f;

    public RotateHandler RotateHandler = new RotateHandler();
    public void Update(Transform transform, float speedMovement, float horizontalInput, float verticalInput)
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            HorizontalMovement(transform, speedMovement, horizontalInput);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            VerticalMovement(transform, speedMovement, verticalInput);
        }
    }
    public void HorizontalMovement(Transform transform, float Speed, float horizontalInput)
    {
        transform.Translate(horizontalInput * Speed * Time.deltaTime, 0f, 0f);
    }

    public void VerticalMovement(Transform transform, float Speed, float verticalInput)
    {
        transform.Translate(0f, verticalInput * Speed * Time.deltaTime, 0f);
    }

}
