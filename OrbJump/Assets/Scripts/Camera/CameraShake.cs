using UnityEngine;

public class CameraShake : MonoBehaviour
{
	[SerializeField] private Transform _cameraTransform;

	[SerializeField] private float _shakeDuration = 0.5f;
	[SerializeField] private float _shakeAmount = 0.7f;
	[SerializeField] private float _decreaseFactor = 1.0f;
	[SerializeField] private float _shakeRate = 0.05f;

	private Vector3 _originalPos;
	private float   _currentShakeDuration;

	public void Shake()
	{
		_currentShakeDuration = _shakeDuration;
		InvokeRepeating("DoShake", 0, _shakeRate);
		_originalPos = _cameraTransform.localPosition;
	}

	private void DoShake()
	{
		if (_currentShakeDuration > 0)
		{
			_cameraTransform.position = _originalPos + Random.insideUnitSphere * _shakeAmount;

			_currentShakeDuration -= Time.deltaTime * _decreaseFactor;
		}
		else
		{
			_currentShakeDuration = 0f;
			_cameraTransform.position = _originalPos;
			CancelInvoke("DoShake");
		}
	}
}