using UnityEngine;
using System.Collections;

public class incantations : MonoBehaviour {

	GameObject clouds;
	environmentChanger env;
	// Use this for initialization
	void Start () {
		clouds = GameObject.Find ("cloudHandler");
		env = GameObject.Find("envChanger").GetComponentInChildren<environmentChanger>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startRain()
	{
		clouds.GetComponent<CloudSpawn> ().shouldSpawn = true;
		clouds.GetComponent<CloudSpawn> ().restartClouds ();

	}

	public void startFire(){
		//Kill Clouds
		foreach (CloudScript cs in GameObject.FindObjectsOfType<CloudScript>())
			cs.KillMe ();
		env.raining = false;

	}
}
