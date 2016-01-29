using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    Transform RightArm; // Go between 0 and 180 IJKL
    Transform RightArmLower; // Go 360 IJKL
    Transform LeftArm; // Go between 0 and 180 WASD
    Transform LeftArmLower; // Go 360 WASD


    // Use this for initialization
    void Start () {
        RightArm = GameObject.Find("RightArm").transform;
        RightArmLower = RightArm.transform.GetChild(0);
        LeftArm = GameObject.Find("LeftArm").transform;
        LeftArmLower = LeftArm.transform.GetChild(0);
        Reset();
    }
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.R)) {
            Reset();
        }
	}

    void Reset() {
        RightArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        RightArmLower.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        LeftArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        LeftArmLower.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
}
