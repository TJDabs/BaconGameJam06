using UnityEngine;
using System.Collections;

public class SunScript : MonoBehaviour 
{
	
	private int SunHealth;
	
	
	// Use this for initialization
	void Start () 
	{
		SunHealth = 5;
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		if(SunHealth <= 0)
		{
			//Application.loadedLevel("EndGame");		
		}
    }
	
	// Detect Sun hit and update SunHealth
	void OnCollisionEnter(Collision collision) 
	{ 
  		if(collision.gameObject.tag=="Enemy")
		{ 
			Destroy(collision.gameObject);
			SunHealth -= 1;	
   		} 
	
	}
}