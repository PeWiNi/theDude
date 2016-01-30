using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class waves : MonoBehaviour {

	//Vector3 pos=new Vector3(1f,1f,1f);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.transform.position.x >= 25f)
			gameObject.transform.position = new Vector3 (-25f, gameObject.transform.position.y, gameObject.transform.position.z);
		else	gameObject.transform.position = new Vector3 (gameObject.transform.position.x+Random.Range(0.0001f,0.005f), 
			gameObject.transform.position.y, gameObject.transform.position.z);

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.transform.name == "raft") {
			Destroy (col.gameObject, 0.5f);
			GameObject panel = GameObject.Find ("Panel");
			Image img = panel.GetComponent<Image> ();
			GameObject hero = GameObject.Find ("hero");
			Destroy (hero, 0.5f);
				//panel.SetActive(true);
				img.enabled = true;
			
		}
	}
}
