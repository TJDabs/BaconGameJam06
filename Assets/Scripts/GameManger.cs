using UnityEngine;
using System.Collections;

public class GameManger : MonoBehaviour {
	
	public static string Power;
	
	public static bool redOnCooldown;
	private float redTimer;
	public static bool yellowOnCooldown;
	private float yellowTimer;
	public static bool greenOnCooldown;
	private float greenTimer;
	public static bool blueOnCooldown;
	private float blueTimer;
	public static bool purpleOnCooldown;
	private float purpleTimer;
	
	// Use this for initialization
	void Start () {
		
		//Power = "Purple";
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if(redOnCooldown == true && redTimer >= 0)
		{
			redTimer -= Time.deltaTime;
		}
		else
		{
			redOnCooldown = false;
		}
		
		if(yellowOnCooldown == true && yellowTimer >= 0)
		{
			yellowTimer -= Time.deltaTime;
		}
		else
		{
			yellowOnCooldown = false;
		}
		
		if(greenOnCooldown == true && greenTimer >= 0)
		{
			greenTimer -= Time.deltaTime;
		}
		else
		{
			greenOnCooldown = false;
		}
		
		if(blueOnCooldown == true && blueTimer >= 0)
		{
			blueTimer -= Time.deltaTime;
		}
		else
		{
			blueOnCooldown = false;
		}
		
		if(purpleOnCooldown == true && purpleTimer >= 0)
		{
			purpleTimer -= Time.deltaTime;
		}
		else
		{
			purpleOnCooldown = false;
		}
	
		
		
		//Keyboard controls
		if (Input.GetKeyDown(KeyCode.Q) == true)
		{
			Power = "Red";
		}
		else if (Input.GetKeyDown(KeyCode.W) == true)
		{
			Power = "Yellow";
		}
		else if (Input.GetKeyDown(KeyCode.E) == true)
		{
			Power = "Green";
		}
		else if (Input.GetKeyDown(KeyCode.R) == true)
		{
			Power = "Blue";
		}
		else if (Input.GetKeyDown(KeyCode.T) == true)
		{
			Power = "Purple";
		}
	}
	
	public void setTimer(string color)
	{
		if(color == "Red")
		{
			if(redOnCooldown == false)
			{
				redOnCooldown = true;
				redTimer = 3;
			}
		}
		else if(color == "Yellow")
		{
			if(yellowOnCooldown == false)
			{
				yellowOnCooldown = true;
				yellowTimer = 3;
			}
		}
		else if(color == "Green")
		{
			if(greenOnCooldown == false)
			{
				greenOnCooldown = true;
				greenTimer = 3;
			}
		}
		else if(color == "Blue")
		{
			if(blueOnCooldown == false)
			{
				blueOnCooldown = true;
				blueTimer = 3;
			}
		}
		else if(color == "Purple")
		{
			if(purpleOnCooldown == false)
			{
				purpleOnCooldown = true;
				purpleTimer = 3;
			}
		}
	}
}
