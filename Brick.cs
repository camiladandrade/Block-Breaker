using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;
	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		timesHit = 0;
		
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	
	}
	

	
	void OnCollisionEnter2D (Collision2D col){
		timesHit += 1;
		maxHits -= 1;
		print ("times hitted: " + timesHit);
		if (maxHits == 0){
			Destroy(gameObject);
		}
	}
	
	//TODO Remove this method
	void SimulateWin(){
		levelManager.LoadNextLevel();
	}
	
}
