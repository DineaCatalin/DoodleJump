using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform _target;

	private void LateUpdate()
	{
		if (_target.position.y > transform.position.y)
		{
			SetPosition();
		}
	}

	public void Reset()
	{
		SetPosition();
	}

	private void SetPosition()
    {
		Vector3 newPos = new Vector3(transform.position.x, _target.position.y, transform.position.z);
		transform.position = newPos;
	}
}