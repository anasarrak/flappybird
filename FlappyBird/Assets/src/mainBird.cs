using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainBird : MonoBehaviour {
public float Speed = 5.0f;
public bool msg = false;
public float minSpace ;
public float maxSpace ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)){
            jump();
		}
		 if (Input.GetKeyDown("space")){
		 	jump();
		 }
            
        
	}

	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.name == "ground"){
            print("Juego terminado");
        }    
    }
	
	void jump(){
        GetComponent<Rigidbody2D>().velocity = Vector3.up * Speed;	
	}
	

}


