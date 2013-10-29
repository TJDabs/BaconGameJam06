using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	private float health;
	private int speed;
	
	private GameObject gameManager;
	public GameManger gameScript;
	public Transform AOECollider;
	public tk2dSpriteAnimator animation;
	
	public Transform RedAnim;
	public Transform BlueAnim;
	public Transform GreenAnim;
	public Transform YellowAnim;
	
	private float timerDOT = 0;
	private float timerSlow = 0;
	
	// Use this for initialization
	void Start () {
		
		gameManager = GameObject.FindGameObjectWithTag("GameManager");
		gameScript = gameManager.GetComponent<GameManger>();
		
		health = 9f;
		speed = 2;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(health);
		
		if(health <= 8 && health > 7)
		{
			animation.Play("Health2");
		}
		else if(health <= 7 && health > 6)
		{
			animation.Play("Health3");
		}
		else if(health <= 6 && health > 5)
		{
			animation.Play("Health4");
		}
		else if(health <= 5 && health > 4)
		{
			animation.Play("Health5");
		}
		else if(health <= 4 && health > 3)
		{
			animation.Play("Health6");
		}
		else if(health <= 3 && health > 2)
		{
			animation.Play("Health7");
		}
		else if(health <= 2 && health > 1)
		{
			animation.Play("Health8");
		}
		else if(health <= 1 && health > 0)
		{
			animation.Play("Health9");
		}
		else if(health <= 0)
		{
			die ();
		}
		
		//Move at Speed
		transform.Translate(Vector3.left * Time.deltaTime * speed);
		
		//Timers
		if(timerDOT > 0)
		{
			timerDOT -= Time.deltaTime;
			health -= 0.05f;
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

		if(GameManger.Power == "Yellow") //Yellow Power
		{
			if(GameManger.yellowOnCooldown == false)
			{
				Vector3 mousepos = Input.mousePosition;
				Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousepos);
				objectPos.z = 0;
				Instantiate(YellowAnim, objectPos, Quaternion.identity);
				health -= 5f;
				gameScript.playPower("Yellow");
				gameScript.setTimer("Yellow");
			}
		}
		else if(GameManger.Power == "Red") //Red Power
		{
			if(GameManger.redOnCooldown == false)
			{
				Vector3 mousepos = Input.mousePosition;
				Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousepos);
				objectPos.z = 0;
				Instantiate(RedAnim, objectPos, Quaternion.identity);
				timerDOT = 2;
				gameScript.playPower("Red");
				gameScript.setTimer("Red");
			}
		}
		else if(GameManger.Power == "Green") //Green Power
		{
			if(GameManger.greenOnCooldown == false)
			{
				Vector3 gmousepos = Input.mousePosition;
				Vector3 gobjectPos = Camera.main.ScreenToWorldPoint(gmousepos);
				gobjectPos.z = 0;
				Instantiate(GreenAnim, gobjectPos, Quaternion.identity);
				
				Vector3 mousepos = Input.mousePosition;
				Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousepos);
				objectPos.z = 0;
				Instantiate(AOECollider, objectPos, Quaternion.Euler(-90,0,0));
				gameScript.playPower("Green");
				gameScript.setTimer("Green");
			}
		}
		else if(GameManger.Power == "Blue") //Blue Power
		{
			if(GameManger.blueOnCooldown == false)
			{
				Vector3 mousepos = Input.mousePosition;
				Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousepos);
				objectPos.z = 0;
				Instantiate(BlueAnim, objectPos, Quaternion.identity);
				health -= 3;
				timerSlow = 5;
				gameScript.playPower("Blue");
				gameScript.setTimer("Blue");
			}
		}
	}
	
	void die()
	{
		gameScript.playDeath();
		GameManger.Score += 5;
		Destroy(gameObject);
	}
	
	void OnTriggerEnter(Collider collision)
	{
		if(collision.tag == "AOE")
		{
			health -= 7;
			Debug.Log("Hit AOE");
		}
	}
	void OnTriggerStay(Collider collision)
	{
		if(collision.tag == "Purple")
		{
			health -= 0.03f;
		}
	}
}
