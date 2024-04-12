using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputSystem
{
    public Action<KeyCode> Action { get; set; }
}
