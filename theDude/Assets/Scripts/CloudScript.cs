using UnityEngine;
using System.Collections;

public class CloudScript : MonoBehaviour {
    float deAcceleration = -0.1f;
    public float timeSteps = 0.05f;
    float timer = 0;
    float startTime = Time.time;
    environmentChanger env;
    public bool isStopped = false;

    // Use this for initialization
    void Start () {
        timer = timeSteps;
        try {
            env = GameObject.Find("envChanger").GetComponentInChildren<environmentChanger>();
        }
        catch { }
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time - startTime > timer) {
            var cloudFly = GetComponent<Rigidbody>();
            if (cloudFly.velocity.x > 0)
                cloudFly.velocity += new Vector3(1, 0, 0) * deAcceleration;
            if (cloudFly.velocity.x < 0)
                cloudFly.velocity += new Vector3(-1, 0, 0) * deAcceleration;

            timer += timeSteps;
            if (cloudFly.velocity.x < 0.1f && cloudFly.velocity.x > -0.1f) {
                cloudFly.velocity = new Vector3(0, 0, 0);
                //print(transform.position);
                //for(int i = 0; i < (env ? env.durationMultiplier : 25); i++) {
                //    float size = gameObject.GetComponent<SpriteRenderer>().bounds.extents.x;
                //    Instantiate(env ? env.rainDrop : Resources.Load("Prefabs/rainDrop"), new Vector3(transform.position.x + Random.Range(-size, size), transform.position.y + Random.Range(-1f, 0f), 0), Quaternion.identity);
                //} 
                isStopped = true;
                timer = int.MaxValue;
            }
        }
    }

    public void KillMe(float delay = 0.0f) {
        if(isStopped)
            Destroy(this.gameObject, delay + Random.Range(0.2f,1.5f));
    }
}
