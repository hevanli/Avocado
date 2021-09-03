using UnityEngine;
using UnityEngine.Events;

public class OnTrigger : MonoBehaviour {
	public UnityEvent onCollisionEnter;
	public UnityEvent onTriggerEnter;
	public string tagRequired;

	private void OnTriggerEnter(Collider other) {
		if (string.IsNullOrEmpty(tagRequired) || other.tag == tagRequired) {
			onTriggerEnter?.Invoke();
		}
	}
	private void OnCollisionEnter(Collision collision) {
		if (string.IsNullOrEmpty(tagRequired) || collision.gameObject.tag == tagRequired) {
			onCollisionEnter?.Invoke();
		}
	}
}
