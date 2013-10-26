using UnityEngine;
using System.Collections;

public class SunScript : MonoBehaviour 
{
	
	private int SunHealth;
	
	
	// Use this for initialization
	void Start () 
	{
		SunHealth = 100;
	}
	
	
	// Update is called once per frame
	void Update () 
	{

    }
	
	// Detect Sun hit and update SunHealth
	void OnCollisionEnter(Collision collision) 
	{ 
  		if(collision.gameObject.tag=="Enemy")
		{ 
			DestroyObject(Object);
			SunHealth -= 10;
     		Debug.Log("hit" + SunHealth); 
   		} 
	
	}
}