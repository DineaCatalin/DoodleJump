using UnityEngine;

[CreateAssetMenu(menuName = "Input/InputService")]
public class InputService : IInputService
{
    private const string HORIZONTAL_AXIS = "Horizontal";

    public override float GetDirection()
    {
#if UNITY_IPHONE || UNITY_ANDROID
        return GetDirectionFromTouch();
#endif
        return GetDirectionFromAxis();
    }

    private float GetDirectionFromAxis()
    {
        Debug.Log("GetDirectionFromAxis");
        return Input.GetAxis(HORIZONTAL_AXIS);
    }
    
    private float GetDirectionFromTouch()
    {
        Debug.Log("GetDirectionFromTouch");
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            var touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            Debug.Log($"GetDirectionFromTouch touchDeltaPosition {touchDeltaPosition}");
            return touchDeltaPosition.x;
        }
        else
        {
            return 0f;
        }
    }
}
