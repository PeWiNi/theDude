using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoring : MonoBehaviour {
	float startTime;
	float pointMultiplier;
	public static int score;
	public Text text;
	//GameObject hero;
	Image img;

	void Awake(){
		startTime = Time.realtimeSinceStartup;
		//hero = GameObject.Find ("hero");
	}
	// Use this for initialization
	void Start () {
		text = GameObject.Find ("score").GetComponent<Text> ();
		score = 0;
		img = GameObject.Find ("Panel").GetComponent<Image> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		if (!img.enabled) {
			pointMultiplier = Time.realtimeSinceStartup - startTime / 1000f;
			score = (int)((float)score + 0.2123f * pointMultiplier);
			text.text = score.ToString ();
		}

	}
}
