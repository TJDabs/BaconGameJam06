using UnityEngine;
using System.Collections;

public class InstructionsScript : MonoBehaviour {

	public tk2dUIItem button;
	public bool LastScreen = false;
	public static int InstructionScreen =1;
	public tk2dSpriteAnimator animation;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnEnable()
	{
		button.OnClick += Clicked;
	}
	
	void OnDisable()
	{
		button.OnClick -= Clicked;
	}
	
	void Clicked()
	{
		if(InstructionScreen == 10)
		{
			InstructionScreen = 1;
			Application.LoadLevel("Title");
		}
		else
		{
			InstructionScreen++;
			animation.Play("Screen" + InstructionScreen);
			
		}
	}
}
