using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class death : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit2D(Collider2D col)
	{
		GameObject panel = GameObject.Find ("Panel");
		Image img = panel.GetComponent<Image> ();
		if (col.transform.name=="hero")
		{	
			Destroy (col.gameObject,0.5f);
			//panel.SetActive(true);
			img.enabled=true;
		}
	}
}
