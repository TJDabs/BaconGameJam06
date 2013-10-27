using UnityEngine;
using System.Collections;

public class SunScript : MonoBehaviour 
{
	
	private int SunHealth;
	public GameObject sun1;
	public GameObject sun2;
	public GameObject sun3;
	public AudioClip sunHit;
	
	// Use this for initialization
	void Start () 
	{
		SunHealth = 3;
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		if(SunHealth == 2)
		{
			Destroy(sun3);
		}
		else if(SunHealth == 1)
		{
			Destroy(sun2);
		}
		if(SunHealth <= 0)
		{
			Destroy(sun1);
			Application.LoadLevel("EndGame");		
		}
    }
	
	// Detect Sun hit and update SunHealth
	void OnCollisionEnter(Collision collision) 
	{ 
  		if(collision.gameObject.tag=="Enemy")
		{ 
			Destroy(collision.gameObject);
			audio.PlayOneShot(sunHit);
			SunHealth -= 1;	
   		} 
	
	}
}