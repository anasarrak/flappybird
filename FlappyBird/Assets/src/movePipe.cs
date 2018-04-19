using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePipe : MonoBehaviour {

	public float speed = 1.2f;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		/*rb = GetComponent<Rigidbody>();
		rb.isKinematic = true;
		rb.detectCollisions = false;*/
	}
	
	// Update is called once per frame
	void Update () {
		movePipes();
	}

	void movePipes(){
		transform.Translate(-speed * Time.deltaTime,0,0 ); 
	}
}
