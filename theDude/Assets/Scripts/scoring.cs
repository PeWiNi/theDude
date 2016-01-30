using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoring : MonoBehaviour {
	float startTime;
	float pointMultiplier;
	public static int score;
	public Text text;


	void Awake(){
		startTime = Time.realtimeSinceStartup;
	}
	// Use this for initialization
	void Start () {
		text = GameObject.Find ("score").GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		pointMultiplier = Time.realtimeSinceStartup - startTime/600f;
		score = (int)((float)score + 3.5123f * pointMultiplier);
		text.text = score.ToString ();
	}
}
