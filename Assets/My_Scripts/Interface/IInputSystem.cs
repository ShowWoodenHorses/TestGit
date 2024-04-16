using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputSystem
{
    public float Speed { get; }
    public void HorizontalMovement(Transform transform, float Speed);
    public void VerticalMovement(Transform transform, float Speed);
}
