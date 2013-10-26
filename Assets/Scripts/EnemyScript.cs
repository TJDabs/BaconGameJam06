using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	private int health;
	private bool Clicked = false;
	private int speed;
	
	// Use this for initialization
	void Start () {
		health = 10;
		speed = 2;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Do purple Power
		if(Clicked == true && GameManger.Power == "Purple")
		{
			Debug.Log("True");
		}
		
		//Move at Speed
		transform.Translate(Vector3.left * Time.deltaTime * speed);
	}
	
	void OnMouseDown()
	{
		Clicked = true;

		if(GameManger.Power == "Yellow") //Yellow Power
		{
			health -= 5;
			Debug.Log(health);
		}
		else if(GameManger.Power == "Red") //Red Power
		{
			
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
		
	}
}
