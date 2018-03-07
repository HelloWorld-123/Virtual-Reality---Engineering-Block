using UnityEngine;
using System.Collections;

public class NormalDoor : MonoBehaviour {
	Animator animator;
	bool NormalDoorOpen;
	// Use this for initialization
	void Start () {
		NormalDoorOpen = false;
		animator = GetComponent<Animator>();
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			NormalDoorOpen=true;
			DoorControl ("Open");
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (NormalDoorOpen) {
			NormalDoorOpen=false;
			DoorControl("Close");
		}
	}
	
	// Update is called once per frame
	void DoorControl (string direction) {
		animator.SetTrigger(direction);
		
	}
}
