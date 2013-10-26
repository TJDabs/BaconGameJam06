using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	private int health;
	private bool Clicked = false;
	
	// Use this for initialization
	void Start () {
		health = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Do purple Power
		if(Clicked == true && GameManger.Power == "Purple")
		{
			Debug.Log("True");
		}
	}
	
	void OnMouseDown()
	{
		Clicked = true;

		if(GameManger.Power == "Yellow")
		{
			health -= 5;
			Debug.Log(health);
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
