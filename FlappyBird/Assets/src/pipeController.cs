﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeController : MonoBehaviour {

	public GameObject obj1;
	public GameObject obj2;
	public GameObject obj3;
	public GameObject obj4;
	public GameObject objPosition;
	int count = 0 ; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
			print("entra");
		count = Random.Range(1,4);
		print(objPosition.transform.position);
		if(col.gameObject.tag == "obstacles"){
			if(count == 1){
				Instantiate(obj1,objPosition.transform.position,Quaternion.identity);
			}else
			if(count == 2){
				Instantiate(obj2,objPosition.transform.position,Quaternion.identity);
			}else
			if(count == 3){
				Instantiate(obj3,objPosition.transform.position,Quaternion.identity);
			}else
			if(count == 4){
				Instantiate(obj4,objPosition.transform.position,Quaternion.identity);
			}
		}
	}
}
