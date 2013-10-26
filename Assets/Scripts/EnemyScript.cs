using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	private float health;
	private bool Clicked = false;
	private int speed;
	
	private float timerDOT = 0;
	
	// Use this for initialization
	void Start () {
		health = 10f;
		speed = 2;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Do purple Power
		if(Clicked == true && GameManger.Power == "Purple")
		{
			Debug.Log("True");
		}
		
		//Check if dead
		if(health <= 0)
		{
			die ();
		}
		
		//Move at Speed
		transform.Translate(Vector3.left * Time.deltaTime * speed);
		
		//Timers
		if(timerDOT >= 0)
		{
			timerDOT -= Time.deltaTime;
			health -= 0.001f;
			Debug.Log(health);
		}
	}
	
	void OnMouseDown()
	{
		Clicked = true;

		if(GameManger.Power == "Yellow") //Yellow Power
		{
			health -= 5f;
		}
		else if(GameManger.Power == "Red") //Red Power
		{
			timerDOT = 10;
		}
		else if(GameManger.Power == "Green") //Green Power
		{
			
		}
		else if(GameManger.Power == "Blue") //Blue Power
		{
			
		}
	}
	
	void OnMouseUp()
	{
		Clicked = false;
	}

	
	void die()
	{
		Destroy(gameObject);
	}
}
