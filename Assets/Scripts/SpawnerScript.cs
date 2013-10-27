using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
	
	private float timer;
	private float timerBoss;
	private float timerIncreaseLevel;
	
	private float baddieFreq = 5;
	private float bossFreq = 30;
	
	public Transform greyBaddie;
	public Transform[] bossBaddies;
	Vector3 spawnLocation;
	
	// Use this for initialization
	void Start () {
		
		spawnLocation = new Vector3(26,0,2);
		timer = baddieFreq;
		timerBoss = bossFreq;
		timerIncreaseLevel = 40;
		spawnBaddie();
	}
	
	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;
		timerBoss -= Time.deltaTime;
		
		if(timer <= 0)
		{
			spawnBaddie();
			timer = baddieFreq;
		}
		
		if(timerBoss <= 0)
		{
			spawnBoss();
			timerBoss = bossFreq;
		}
		
		if(timerIncreaseLevel <= 0)
		{
			baddieFreq -= 0.2f;
			bossFreq -= 1;
			timerIncreaseLevel = 45;
		}
	
	}
	
	void spawnBaddie()
	{
		int randY = Random.Range(-12, 5);
		//Debug.Log(randY);
		spawnLocation.y = randY;
		Instantiate(greyBaddie, spawnLocation, Quaternion.identity);
	}
	
	void spawnBoss()
	{
		int randNum = Random.Range(0,bossBaddies.Length);
		
		int randY = Random.Range(-12, 5);
		//Debug.Log(randY);
		spawnLocation.y = randY;
		Instantiate(bossBaddies[randNum], spawnLocation, Quaternion.identity);
	}
}
