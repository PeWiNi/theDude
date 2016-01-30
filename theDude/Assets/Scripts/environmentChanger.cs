using UnityEngine;
using System.Collections;

public class environmentChanger : MonoBehaviour {

	public bool raining=false;
	public float duration=2f;
	public float durationMultiplier=1f;
	public GameObject rainDrop;
	public GameObject flame1; 
	public GameObject flame2; 
	public float time;
	public float maXtime=300f;

	public static int noFlames=0;

	public static int noDrops=0;

	// Use this for initialization
	void Start () {
	//	StartCoroutine (fillTheScreen ());
		time = Time.realtimeSinceStartup;

		StartCoroutine(addWave(200f));

	/*	for (int i = 0; i < 2400; i++) {
			int fl = (int)Random.Range (0, 100);
			Vector3 pos = new Vector3 (Random.Range (-18.5f,18.5f ), 0, Random.Range(0.2f,0.5f));
			if (fl <= 50)
				Instantiate (flame1, pos, Quaternion.identity);
			else
				Instantiate (flame2, pos, Quaternion.identity);			
		}*/

	}

	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator fillTheScreen(){
		
		StartCoroutine (addWave (duration*durationMultiplier*10f));

		yield return new WaitForSeconds (duration * durationMultiplier);
		//raining = !raining;
	
		float currentTime = Time.realtimeSinceStartup - time;
		//Debug.Log ("Current time :" + currentTime + " duration :" + duration + " raining: " + raining); 
		currentTime *= 3f;
		//Debug.Log ("Current time :" + currentTime);
		if (currentTime < 300f) {
			
			//Debug.Log ("durationMultiplier :" + durationMultiplier);
			durationMultiplier = durationMultiplier*currentTime/200f+durationMultiplier;
			//Debug.Log ("durationMultiplier :" + durationMultiplier);
		}
		

		//StartCoroutine (fillTheScreen ());
	}

	IEnumerator addWave(float progress){

		while (progress > 0f) {
			yield return new WaitForSeconds (0.001f);

			if (raining) {
				Vector3 pos = new Vector3 (Random.Range (-24.5f, 24.5f), 18.5f, Random.Range (0.02f, 0.03f));
				noDrops++;
				//Debug.Log (noDrops);
				Instantiate (rainDrop, pos, Quaternion.identity);

                //Kill Clouds
                foreach (CloudScript cs in GameObject.FindObjectsOfType<CloudScript>())
                    cs.KillMe();
			} else {
				noFlames++;
				//Debug.Log (noFlames);
				int fl = (int)Random.Range (0, 100);
				Vector3 pos = new Vector3 (Random.Range (-24.5f, 24.5f), -0.8f, Random.Range (0.02f, 0.03f));
				if (fl <= 50)
					Instantiate (flame1, pos, Quaternion.identity);
				else
					Instantiate (flame2, pos, Quaternion.identity);	
				
			}
		}
	}
}
