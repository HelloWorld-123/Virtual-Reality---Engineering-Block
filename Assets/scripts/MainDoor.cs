using UnityEngine;
using System.Collections;

public class MainDoor : MonoBehaviour {
	Animator animator;
	bool mainDoorOpen;
	// Use this for initialization
	void Start () {
		mainDoorOpen = false;
		animator = GetComponent<Animator>();
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			mainDoorOpen=true;
			DoorControl ("Open");
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (mainDoorOpen) {
			mainDoorOpen=false;
			DoorControl("Close");
		}
	}
	
	// Update is called once per frame
	void DoorControl (string direction) {
		animator.SetTrigger(direction);
		
	}
}
