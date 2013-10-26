using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	private float health;
	private bool Clicked = false;
	private int speed;
	
	public GameManger gameScript;
	public Transform AOECollider;
	
	private float timerDOT = 0;
	private float timerSlow = 0;
	
	// Use this for initialization
	void Start () {
		health = 10f;
		speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(health);
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
		if(timerDOT > 0)
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
			speed = 2;
		}
	}
	
	void OnMouseDown()
	{
		Clicked = true;

		if(GameManger.Power == "Yellow") //Yellow Power
		{
			if(GameManger.yellowOnCooldown == false)
			{
				health -= 5f;
				gameScript.setTimer("Yellow");
			}
		}
		else if(GameManger.Power == "Red") //Red Power
		{
			if(GameManger.redOnCooldown == false)
			{
				timerDOT = 10;
				gameScript.setTimer("Red");
			}
		}
		else if(GameManger.Power == "Green") //Green Power
		{
			if(GameManger.greenOnCooldown == false)
			{
				Vector3 mousepos = Input.mousePosition;
				Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousepos);
				Instantiate(AOECollider, objectPos, Quaternion.Euler(-90,0,0));
				gameScript.setTimer("Green");
			}
		}
		else if(GameManger.Power == "Blue") //Blue Power
		{
			if(GameManger.blueOnCooldown == false)
			{
				timerSlow = 5;
				gameScript.setTimer("Blue");
			}
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
	
	void OnTriggerEnter(Collider collision)
	{
		if(collision.tag == "AOE")
		{
			health -= 3;
			Debug.Log("Hit AOE");
		}
	}
}
