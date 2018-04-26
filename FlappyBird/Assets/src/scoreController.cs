using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoreController : MonoBehaviour
{
    public Text scoreText = null;

    public static int puntuacion = 0;

    // Use this for initialization
    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        scoreText.text = "Score: " + puntuacion.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "bird")
        {
            try
            {
                puntuacion++;
                scoreText.text = "Score: " + puntuacion.ToString();
                //print("triggerEnter " + puntuacion.ToString());
            }
            catch (NullReferenceException ex)
            {
                Debug.LogException(ex, this);
            }
            
        }
    }

}