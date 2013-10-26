using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	private float health;
	private bool Clicked = false;
	private int speed;
	
	private float timerDOT = 0;
	private float timerSlow = 0;
	
	// Use this for initialization
	void Start () {
		health = 10f;
		speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(health);
		//Do purple Power
		if(Clicked == true && GameManger.Power == "Purple")
		{
			health -= 0.01f;
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
		}
		
		if(timerSlow > 0)
		{
			timerSlow -= Time.deltaTime;
			speed = 1;
		}
		else
		{
			speed = 5;
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
			timerSlow = 5;
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
