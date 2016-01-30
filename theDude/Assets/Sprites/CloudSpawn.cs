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

    // Use this for initialization
    void Start () {
        timer = timeSteps;
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > timer && cloudCount < maxClouds) {
            int rngType = Random.Range(0, 2);
            int rngSide = Random.Range(0, 2);
            float rngDistance = Random.Range(0, 1f);
            float rngSpeed = Random.Range(2f, 6f);

            GameObject cloud = (GameObject)Instantiate(rngType == 0 ? cloud1 : cloud2, 
                new Vector3(rngSide  == 0 ? -horizontalBounds : horizontalBounds, cloudLayer + rngDistance, 0), Quaternion.identity);
            var cloudFly = cloud.GetComponent<Rigidbody>();
            cloudFly.velocity = new Vector3(rngSide == 0 ? 1 : -1, 0, 0) * rngSpeed;

            cloudCount++;
            timer += timeSteps;
        }
    }
}
