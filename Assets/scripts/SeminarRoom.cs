using UnityEngine;
using System.Collections;

public class SeminarRoom : MonoBehaviour {
	Animator animator;
	bool SeminarRoomOpen;
	// Use this for initialization
	void Start () {
		SeminarRoomOpen = false;
		animator = GetComponent<Animator>();
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			SeminarRoomOpen=true;
			DoorControl ("Open");
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (SeminarRoomOpen) {
			SeminarRoomOpen=false;
			DoorControl("Close");
		}
	}
	
	// Update is called once per frame
	void DoorControl (string direction) {
		animator.SetTrigger(direction);
		
	}
}
