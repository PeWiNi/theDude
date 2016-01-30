using UnityEngine;
using System.Collections;

public class environmentChanger : MonoBehaviour {

	public bool raining=false;
	public float duration=20f;
	public float durationMultiplier=1f;
	public GameObject rainDrop;
	public GameObject flame1; 
	public GameObject flame2; 
	public float time;
	public float maXtime=300f;


	// Use this for initialization
	void Start () {
		StartCoroutine (fillTheScreen ());
		time = Time.realtimeSinceStartup;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator fillTheScreen(){
		for (int i = 0; i < duration*durationMultiplier; i++) { 
			StartCoroutine (addWave ());
		}

		yield return new WaitForSeconds (duration * durationMultiplier);
		raining = !raining;
	
		float currentTime = Time.realtimeSinceStartup - time;
		Debug.Log ("Current time :" + currentTime + " duration :" + duration * durationMultiplier + " raining: " + raining); 
		if (currentTime * 3f < 300f)
			durationMultiplier *= currentTime * 3f / 200f;

		StartCoroutine (fillTheScreen ());
	}

	IEnumerator addWave(){
		yield return new WaitForSeconds (1f);

		if (raining) 
		{
			Vector3 pos = new Vector3 (Random.Range (-9.5f,9.5f ), 11, Random.Range(0.2f,0.5f));
			Instantiate (rainDrop, pos, Quaternion.identity);
		} 
		else 
		{
			int fl = (int)Random.Range (0, 100);
			Vector3 pos = new Vector3 (Random.Range (-9.5f,9.5f ), 0, Random.Range(0.2f,0.5f));
			if (fl <= 50)
				Instantiate (flame1, pos, Quaternion.identity);
			else
				Instantiate (flame2, pos, Quaternion.identity);			
		}
	}
}
