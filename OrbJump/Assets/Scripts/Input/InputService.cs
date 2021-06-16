using UnityEngine;

[CreateAssetMenu(menuName = "Input/InputService")]
public class InputService : IInputService
{
    private const string HORIZONTAL_AXIS = "Horizontal";

    [Range(0,0.5f)]
    public float TouchDamp;

    // Best practice would be to split this in 2 different IInputServices and 
    // have another script decide which to use
    public override float GetDirection()
    {
        float direction = GetDirectionFromTouch();
        if(direction == 0)
        {
            direction = GetDirectionFromAxis();
        }

        return direction;

    }

    private float GetDirectionFromAxis()
    {
        return Input.GetAxis(HORIZONTAL_AXIS);
    }
    
    private float GetDirectionFromTouch()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            var touchDeltaPosition = Vector3.Normalize(Input.GetTouch(0).deltaPosition);
            return touchDeltaPosition.x - TouchDamp;
        }
        else
        {
            return 0f;
        }
    }
}
