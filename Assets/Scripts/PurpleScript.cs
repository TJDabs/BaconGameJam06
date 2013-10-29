using UnityEngine;
using System.Collections;

public class PurpleScript : MonoBehaviour {
	
	private Vector3 screenPoint;
	private Vector3 offset;
	
	// Use this for initialization
	void Start () {
		
		
		
		Vector3 currentPos = new Vector3(0,0,0);
		currentPos = transform.position;
		transform.position = new Vector3(currentPos.x, currentPos.y, 1.9f);
		
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButtonUp(0))
		{
			Destroy(gameObject);
		}
		
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		
		transform.position = curPosition;
	
	}

}
