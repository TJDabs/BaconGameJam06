using UnityEngine;
using System.Collections;

public class RainbowScript : MonoBehaviour {
	
	public string Color;
	public tk2dSprite Sprite;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Color == GameManger.Power)
		{
			Sprite.SetSprite(Color + "-highlight");
		}
		else
		{
			Sprite.SetSprite(Color);
		}
	
	}
	
	void OnMouseDown()
	{
		GameManger.Power = Color;
		Debug.Log(GameManger.Power);
	}
}
