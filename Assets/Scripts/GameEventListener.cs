using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
	[Tooltip("Event to register with.")]
	public GameEvent myEvent;
	
	[Tooltip("Response to invoke when Event is raised.")]
	public UnityEvent response;

	private void OnEnable()
	{
		myEvent.RegisterListener(this);
	}

	private void OnDisable()
	{
		myEvent.UnregisterListener(this);
	}

	public void OnEventRaised()
	{
		response.Invoke();
	}
}