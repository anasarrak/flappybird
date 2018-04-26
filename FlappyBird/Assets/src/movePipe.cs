using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePipe : MonoBehaviour {

	public float speed = 1.2f;

    //public mainBird gameObject;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		movePipes();
    }

	void movePipes(){
		transform.Translate(-speed * Time.deltaTime,0,0 ); 
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "bird")
        {
            //print("bird toched");
        }
    }
}
