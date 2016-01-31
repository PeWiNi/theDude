using UnityEngine;
using System.Collections;

public class CloudSpawn : MonoBehaviour {
    public GameObject cloud1;
    public GameObject cloud2;
    public int maxClouds = 8;
    public float cloudLayer = 3f;
    public float horizontalBounds = 9f;
    private int cloudCount = 0;
    public float timeSteps = 0.1f;
    float timer = 0;
	public bool shouldSpawn=false;
	public bool spawned=false;
	public bool stopped = false; 

	environmentChanger env;

    // Use this for initialization
    void Start () {
        timer = timeSteps;
		env = GameObject.Find("envChanger").GetComponentInChildren<environmentChanger>();
	
    }
	
	// Update is called once per frame
	void Update () {
		if (shouldSpawn) {
			spawnDemClouds ();

		}
		else if(spawned)
		{		stopped = false;
				foreach (CloudScript cs in GameObject.FindObjectsOfType<CloudScript>())
				if (cs.isStopped) {
					stopped = true;
				}else break;
			if (stopped) {
				env.raining = true;
				env.StartCoroutine (env.fillTheScreen ());
				stopped = false;
				spawned = false;
			}
		}
    }

	public void restartClouds(){
		timer = 0;
		cloudCount = 0;
		spawned = false;
	}

	public void spawnDemClouds(){
		if (Time.time > timer && cloudCount < maxClouds) {
			int rngType = Random.Range (0, 2);
			int rngSide = Random.Range (0, 2);
			float rngDistance = Random.Range (0, 3f);
			float rngSpeed = Random.Range (3f, 8f);

			GameObject cloud = (GameObject)Instantiate (rngType == 0 ? cloud1 : cloud2, 
				                   new Vector3 (rngSide == 0 ? -horizontalBounds : horizontalBounds, cloudLayer + rngDistance, 0), Quaternion.identity);
			var cloudFly = cloud.GetComponent<Rigidbody> ();
			cloudFly.velocity = new Vector3 (rngSide == 0 ? 1 : -1, 0, 0) * rngSpeed;

			cloudCount++;
			timer += timeSteps;

		} else {
			shouldSpawn = false;
			spawned = true;


		}
	}



}
