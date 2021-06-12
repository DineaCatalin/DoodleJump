using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform _target;

	void LateUpdate()
	{
		if (_target.position.y > transform.position.y)
		{
			Vector3 newPos = new Vector3(transform.position.x, _target.position.y, transform.position.z);
			transform.position = newPos;
		}
	}
}