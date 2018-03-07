using UnityEngine;
using System.Collections;

public class moveSpeed : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		speed = 5f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speed*Input.GetAxis("Horizontal")*Time.deltaTime,0,speed*Input.GetAxis("Vertical")*Time.deltaTime);
		
	}
}
