using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainBird : MonoBehaviour {
public float Speed = 5.0f;
public bool msg = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)){
            jump();
		}

    	if(msg){
    		//alert("toca");
    	}
        

		
	}
	void jump(){
        GetComponent<Rigidbody2D>().velocity = Vector3.up * Speed;	
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "ground"){
			msg = true;
			print("toca");
		}
	}

}


