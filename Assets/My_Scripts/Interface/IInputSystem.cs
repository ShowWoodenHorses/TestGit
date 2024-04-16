using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputSystem
{
    public float Speed { get; }
    public void HorizontalMovement(Transform transform, float Speed, float horizontalMove);
    public void VerticalMovement(Transform transform, float Speed, float verticalMove);

    public void Update(Transform transform, 
        float speed, 
        float horizontalInput, 
        float verticalInput);
}
