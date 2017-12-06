using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	public static int musicCounter = 0;

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad(gameObject);
		musicCounter++;
		if(musicCounter > 1){
			GameObject.DestroyObject(gameObject);
		
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
