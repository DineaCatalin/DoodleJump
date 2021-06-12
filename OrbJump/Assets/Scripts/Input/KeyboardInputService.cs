using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Input/Keyboard")]
public class KeyboardInputService : IInputService
{
    private const string HORIZONTAL_AXIS = "Horizontal";

    public override float GetDirection()
    {
        return Input.GetAxis(HORIZONTAL_AXIS);
    }
}
