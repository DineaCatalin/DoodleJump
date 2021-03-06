using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/GameEvent")]
public class GameEvent : ScriptableObject
{
	private List<GameEventListener> _listeners = new List<GameEventListener>();

	public void Raise()
	{
		for (int i = 0; i <_listeners.Count; i++)
		{
			_listeners[i].OnEventRaised();
		}
	}

	public void RegisterListener(GameEventListener listener)   => _listeners.Add(listener);
	public void UnregisterListener(GameEventListener listener) => _listeners.Remove(listener);
}