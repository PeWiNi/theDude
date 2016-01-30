using UnityEngine;
using System.Collections;

public class flames : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5f);
	//	environmentChanger.noFlames--;
		//Debug.Log (environmentChanger.noFlames);
	}
	
	// Update is called once per frame

		void Update () {
			
		}

		void OnCollisionEnter2D(Collision2D col)
		{
			
			if (col.transform.name == "raft")
				shrink ();
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

