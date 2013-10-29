using UnityEngine;
using System.Collections;

public class RainbowScript : MonoBehaviour {
	
	public string Color;
	public tk2dSprite Sprite;
	public GameManger gameScript;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//IF RED
		if(Color == "Red")
		{
			if(GameManger.redOnCooldown == true)
			{
				Sprite.SetSprite("Red-cooldown");
			}
			else if(Color == GameManger.Power)
			{
				Sprite.SetSprite(Color + "-highlight");
			}
			else
			{
				Sprite.SetSprite(Color);
			}
		}
		//YELLOW
		if(Color == "Yellow")
		{
			if(GameManger.yellowOnCooldown == true)
			{
				Sprite.SetSprite("Yellow-cooldown");
			}
			else if(Color == GameManger.Power)
			{
				Sprite.SetSprite(Color + "-highlight");
			}
			else
			{
				Sprite.SetSprite(Color);
			}
		}
		//GREEN
		if(Color == "Green")
		{
			if(GameManger.greenOnCooldown == true)
			{
				Sprite.SetSprite("Green-cooldown");
			}
			else if(Color == GameManger.Power)
			{
				Sprite.SetSprite(Color + "-highlight");
			}
			else
			{
				Sprite.SetSprite(Color);
			}
		}
		//BLUE
		if(Color == "Blue")
		{
			if(GameManger.blueOnCooldown == true)
			{
				Sprite.SetSprite("Blue-cooldown");
			}
			else if(Color == GameManger.Power)
			{
				Sprite.SetSprite(Color + "-highlight");
			}
			else
			{
				Sprite.SetSprite(Color);
			}
		}
		//PURPLE
		if(Color == "Purple")
		{
			if(GameManger.purpleOnCooldown == true)
			{
				Sprite.SetSprite("Purple-cooldown");
			}
			else if(Color == GameManger.Power)
			{
				Sprite.SetSprite(Color + "-highlight");
			}
			else
			{
				Sprite.SetSprite(Color);
			}
		}
	
	}
	
	void OnMouseDown()
	{
		GameManger.Power = Color;
		gameScript.playPing(Color);
		Debug.Log(GameManger.Power);
	}
}
