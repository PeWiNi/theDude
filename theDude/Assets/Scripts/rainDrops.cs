using UnityEngine;
using System.Collections;

public class rainDrops : MonoBehaviour {


	// Use this for initialization
	void Start () {

		Destroy (gameObject, 2.5f);
		//environmentChanger.noDrops--;
		//Debug.Log (environmentChanger.noDrops);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D col)
	{
//		Debug.Log (col.transform.name);
		if (col.transform.name == "flame1(Clone)" || col.transform.name == "flame2(Clone)")
			Destroy (col.gameObject);
			Destroy (gameObject);
		if (col.transform.name == "raft")
			move ();
	}
	void move(){
		Debug.Log ("moving");
	}
}
