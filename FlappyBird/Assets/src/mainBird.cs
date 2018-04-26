using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Database;
using Firebase;
using Firebase.Unity.Editor;
public class User
{
    public string user;
    public int score;

    public User(string user, int score)
    {
        this.user = user;
        this.score = score;
    }
}
public class mainBird : MonoBehaviour {
    public float Speed = 5.0f;
    public bool msg = false;
    public int playerScore = 0;
    public bool stops = false;
    public Text gameOver = null;
    public Text restart = null;
    private DatabaseReference db;
    private FirebaseApp Firebase;
    private FirebaseApp mref;

    void Awake()
    {
        

    }
    // Use this for initialization
    void Start () {
        gameOver = GameObject.Find("gameOverText").GetComponent<Text>();
        gameOver.text = "Game Over";
        gameOver.enabled = false;
        restart = GameObject.Find("Restart").GetComponent<Text>();
        restart.enabled = false;

        
        
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
            
            GameControl gc = new GameControl();

            mref = FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://flappybird-aa5a0.firebaseio.com/");

            mref.Child("name").setValue("asdsadsadasdsasa");
            //User user = new User(gc.newUser.DisplayName,50);
            //string json = JsonUtility.ToJson(user);
            //DatabaseReference dbRef = FirebaseDatabase.DefaultInstance.RootReference;

            //dbRef.Child("name").SetValueAsync("asdddddddd");
            gameOver.enabled = true;
            restart.enabled = true;
            stop();
        }
        
        if(coll.gameObject.tag == "obstacles"){
            gameOver.enabled = true;
            restart.enabled = true;
            stop();
        }

    }

    void stop()
    {
        
    }
	
	void jump(){
        GetComponent<Rigidbody2D>().velocity = Vector3.up * Speed;	
	}
	
}


