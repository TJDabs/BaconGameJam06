using UnityEngine;
using System.Collections;

public class RainbowScript : MonoBehaviour {
	
	public string Color;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown()
	{
		GameManger.Power = Color;
		Debug.Log(GameManger.Power);
	}
}
