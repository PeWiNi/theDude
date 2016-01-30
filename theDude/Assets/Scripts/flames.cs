using UnityEngine;
using System.Collections;

public class flames : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 10f);
		environmentChanger.noFlames--;
		Debug.Log (environmentChanger.noFlames);
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
		Debug.Log ("make raft smaller");
	}

	}

