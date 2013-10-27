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
	
	public Transform PurpleAnim;
	public tk2dTextMesh txtScore;
	public static int Score;
	
	public AudioClip redsfx;
	public AudioClip yellowsfx;
	public AudioClip greensfx;
	public AudioClip bluesfx;
	public AudioClip purplesfx;
	
	public AudioClip redsfxP;
	public AudioClip yellowsfxP;
	public AudioClip greensfxP;
	public AudioClip bluesfxP;
	public AudioClip purplesfxP;
	
	public AudioClip[] baddieDeaths;
	
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
			playPing(Power);
		}
		else if (Input.GetKeyDown(KeyCode.W) == true)
		{
			Power = "Yellow";
			playPing(Power);
		}
		else if (Input.GetKeyDown(KeyCode.E) == true)
		{
			Power = "Green";
			playPing(Power);
		}
		else if (Input.GetKeyDown(KeyCode.R) == true)
		{
			Power = "Blue";
			playPing(Power);
		}
		else if (Input.GetKeyDown(KeyCode.T) == true)
		{
			Power = "Purple";
			playPing(Power);
		}
		
		//Check if mouse is clicked
		if(Input.GetMouseButtonDown(0))
		{
			if(Power == "Purple")
			{
				if(purpleOnCooldown == false)
				{
					Vector3 mousepos = Input.mousePosition;
					Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousepos);
					objectPos.z = 2;
					playPower("Purple");
					Instantiate(PurpleAnim, objectPos, Quaternion.identity);
				}
			}
		}
		if(Input.GetMouseButtonUp(0))
		{
			audio.loop = false;
		}
		
		//Draw Score
		txtScore.text = string.Format("Score: " + Score);
		txtScore.Commit();
	}
	
	public void setTimer(string color)
	{
		if(color == "Red")
		{
			if(redOnCooldown == false)
			{
				redOnCooldown = true;
				redTimer = 2;
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
				greenTimer = 4;
			}
		}
		else if(color == "Blue")
		{
			if(blueOnCooldown == false)
			{
				blueOnCooldown = true;
				blueTimer = 2;
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
	
	public void playPing(string Color)
	{
		if(Color == "Red")
		{
			audio.PlayOneShot(redsfx);
		}
		else if(Color == "Yellow")
		{
			audio.PlayOneShot(yellowsfx);
		}
		else if(Color == "Green")
		{
			audio.PlayOneShot(greensfx);
		}
		else if(Color == "Blue")
		{
			audio.PlayOneShot(bluesfx);
		}
		else if(Color == "Purple")
		{
			audio.PlayOneShot(purplesfx);
		}
	}
	public void playPower(string Color)
	{
		if(Color == "Red")
		{
			audio.PlayOneShot(redsfxP);
		}
		else if(Color == "Yellow")
		{
			audio.PlayOneShot(yellowsfxP);
		}
		else if(Color == "Green")
		{
			audio.PlayOneShot(greensfxP);
		}
		else if(Color == "Blue")
		{
			audio.PlayOneShot(bluesfxP);
		}
		else if(Color == "Purple")
		{
			audio.clip = purplesfxP;
			audio.loop = true;
			audio.Play();
			//audio.PlayOneShot(purplesfxP);
		}
	}
	public void playDeath()
	{
		int randNum = Random.Range(0,baddieDeaths.Length);
		audio.PlayOneShot(baddieDeaths[randNum]);
	}
}
