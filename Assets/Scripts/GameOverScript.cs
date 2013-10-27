using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {
	
	public tk2dTextMesh txtScore;
	
	// Use this for initialization
	void Start () {
		txtScore.text = string.Format("Score: " + GameManger.Score);
		txtScore.Commit();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
