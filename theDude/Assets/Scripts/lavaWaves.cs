using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class lavaWaves : MonoBehaviour {

	//Vector3 pos=new Vector3(1f,1f,1f);
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (transform.position.x <= -25f)
			transform.position = new Vector3 (25f, transform.position.y,1f);
		else	transform.position = new Vector3 (transform.position.x-Random.Range(0.0001f,0.005f), 
			transform.position.y, 1f);

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.transform.name == "raft") {
			shrink ();
		}
	}

	void shrink(){
		//	Debug.Log ("make raft smaller");
		GameObject raft = GameObject.Find ("raft");
		Vector3 shrinked = new Vector3 (raft.transform.localScale.x*0.995f,raft.transform.localScale.y *0.995f,1);
		raft.transform.localScale = shrinked;
		GameObject pole = GameObject.Find ("pole");
		shrinked = new Vector3 (pole.transform.localScale.x * 0.995f, pole.transform.localScale.y, 1);
		pole.transform.localScale = shrinked;
	}
}
