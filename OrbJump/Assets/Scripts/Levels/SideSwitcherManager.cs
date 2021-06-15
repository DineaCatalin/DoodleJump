using UnityEngine;

public class SideSwitcherManager : MonoBehaviour
{
    [SerializeField] private SideSwitcher _left;
    [SerializeField] private SideSwitcher _right;
    [SerializeField] private float        _switchOffset;

    private void Start()
    {
        var screenMidLeft  = new Vector3(0, Screen.width / 2);
        var screenMidRight = new Vector3(Screen.width, Screen.width / 2);

        var levelLeftEdge  = Camera.main.ScreenToWorldPoint(screenMidLeft);
        var levelRightEdge = Camera.main.ScreenToWorldPoint(screenMidRight);

        _left.transform.position  = levelLeftEdge;
        _right.transform.position = levelRightEdge;

        _left.XPosition  = levelLeftEdge.x  + _switchOffset;
        _right.XPosition = levelRightEdge.x - _switchOffset;
    }
}
