using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class masterWave : MonoBehaviour {

	Vector3 enlarge=new Vector3(1f,1f,1f);
	Vector3 shrink=new Vector3(1f,1f,1f);
	public GameObject lavaWaves;	
	GameObject panel;
	Image img;
	public environmentChanger env;

	// Use this for initialization
	void Awake()
	{
		lavaWaves = GameObject.Find("lavaWaves");
		env = GameObject.Find ("envChanger").GetComponent<environmentChanger> ();
	}

	void Start () 
	{
		panel= GameObject.Find ("Panel");
		img= panel.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {


		if(env.raining) 
		{
			if (lavaWaves.transform.localScale.y > 0.01f )
			{	lavaWaves.transform.localScale = new Vector3 (lavaWaves.transform.localScale.x, 
				lavaWaves.transform.localScale.y-environmentChanger.noDrops / 1000000f,
				lavaWaves.transform.localScale.z);
			}
			else
			{
				enlarge = new Vector3 (transform.localScale.x,
					transform.localScale.y + environmentChanger.noDrops / 1000000f,
					transform.localScale.z);
				gameObject.transform.localScale = enlarge;
				Vector3 newPos = new Vector3 (gameObject.transform.position.x, 
					                 //gameObject.transform.position.y + environmentChanger.noDrops / 1000000f,
					-1.55f,
					                 gameObject.transform.position.z);
				gameObject.transform.position = newPos;
			}
		}
		else
		if (environmentChanger.noFlames >= 0 && transform.localScale.y > 0.01f) 
		{
			shrink = new Vector3 (transform.localScale.x,
				transform.localScale.y - environmentChanger.noFlames / 1000000f,
				transform.localScale.z);
			gameObject.transform.localScale = shrink;
		Vector3 newPos = new Vector3 (gameObject.transform.position.x, 
				//gameObject.transform.position.y - environmentChanger.noFlames / 1000000f,
					-1.55f,
				gameObject.transform.position.z);
			gameObject.transform.position = newPos;
		}
						
	
		if (img.enabled == true)
			Destroy (gameObject);		
	}
}
