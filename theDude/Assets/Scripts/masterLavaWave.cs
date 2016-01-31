using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class masterLavaWave : MonoBehaviour {

	Vector3 enlarge=new Vector3(1f,1f,1f);
	Vector3 shrink=new Vector3(1f,1f,1f);
	public GameObject waterWaves;


	//GameObject panel;
//	Image img;
	public environmentChanger env;
	// Use this for initialization


	void Awake () {
		waterWaves = GameObject.Find ("waves");
		env = GameObject.Find ("envChanger").GetComponent<environmentChanger> ();
	}

	void Start(){
		
	}

	// Update is called once per frame
	void Update () {

		if (!env.raining)
			if (waterWaves.transform.localScale.y <= 0.01f) 
			{
				enlarge = new Vector3 (transform.localScale.x,
				transform.localScale.y + (environmentChanger.noFlames /1000000f),
					transform.localScale.z);
				gameObject.transform.localScale = enlarge;
			/*Vector3 newPos = new Vector3 (gameObject.transform.position.x, 
					                gameObject.transform.position.y,
					                 gameObject.transform.position.z);
				gameObject.transform.position = newPos;*/
			}
					
		GameObject panel = GameObject.Find ("Panel");
		Image img = panel.GetComponent<Image> ();
		if (img.enabled == true)
			Destroy (gameObject);		
	}
}
