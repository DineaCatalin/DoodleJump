using UnityEngine;

public class PlatformInteractionTracker : MonoBehaviour
{
    [SerializeField] private IntVariable _platformsTouched;

    public void OnPlatformTouched() => _platformsTouched.Value++;

    public void ResetTracker()      => _platformsTouched.Value = 0;
}
