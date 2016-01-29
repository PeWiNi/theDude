using UnityEngine;
using System.Collections;

public class environmentChanger : MonoBehaviour {

	public bool raining=false;
	public float duration=20f;
	public float durationMultiplier=1f;
	public GameObject rainDrop;
	public GameObject flame; 

	// Use this for initialization
	void Start () {
		StartCoroutine (fillTheScreen ());

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
	}

	IEnumerator addWave(){
	
	}
}
