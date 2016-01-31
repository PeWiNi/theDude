using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class masterLavaWave : MonoBehaviour {

	Vector3 enlarge=new Vector3(1f,1f,1f);
	Vector3 shrink=new Vector3(1f,1f,1f);
	public GameObject waterWaves;
	// Use this for initialization
	void Start () {
		waterWaves = GameObject.Find ("waves");
	}

	// Update is called once per frame
	void Update () {
		if (waterWaves.transform.localScale.y <= 0.01f) {
			if (environmentChanger.noFlames >= 0) {
				enlarge = new Vector3 (transform.localScale.x,
					transform.localScale.y + environmentChanger.noFlames / 800000f,
					transform.localScale.z);
				gameObject.transform.localScale = enlarge;
			Vector3 newPos = new Vector3 (gameObject.transform.position.x, 
					                // gameObject.transform.position.y + environmentChanger.noFlames / 1600000f,
									-1.55f,
					                 gameObject.transform.position.z);
				gameObject.transform.position = newPos;
			}
		} else {
			if (environmentChanger.noDrops >= 0 && transform.localScale.y > 0.01f) {
				shrink = new Vector3 (transform.localScale.x,
					transform.localScale.y - environmentChanger.noDrops / 1000000f,
					transform.localScale.z);
				gameObject.transform.localScale = shrink;
			Vector3 newPos = new Vector3 (gameObject.transform.position.x, 
					                //gameObject.transform.position.y - environmentChanger.noDrops / 1000000f,
								-1.55f,
									gameObject.transform.position.z);
				gameObject.transform.position = newPos;
			}
		}
				
		GameObject panel = GameObject.Find ("Panel");
		Image img = panel.GetComponent<Image> ();
		if (img.enabled == true)
			Destroy (gameObject);		
	}
}
