using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    Transform RightArm; // IJKL
    Transform RightArmLower; // IJKL
    Transform LeftArm; // WASD
    Transform LeftArmLower; // WASD


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
        Rotation(RightArm, false);
        Rotation(LeftArm, true);
    }

    void Rotation(Transform t, bool WASD) { //Alt to WASD is IJKL
        if (Input.GetKey(WASD ? KeyCode.W : KeyCode.I)) {
            if (t.rotation.eulerAngles.z >= 0)
                t.rotation = Quaternion.Euler(Vector3.Lerp(t.rotation.eulerAngles, new Vector3(0, 0, 180), Time.deltaTime));
            else
                t.rotation = Quaternion.Euler(Vector3.Lerp(t.rotation.eulerAngles, new Vector3(0, 0, -180), Time.deltaTime));
        }
        if (Input.GetKey(WASD ? KeyCode.A : KeyCode.J)) {
            if (t.rotation.eulerAngles.z <= 90)
                t.rotation = Quaternion.Euler(Vector3.Lerp(t.rotation.eulerAngles, new Vector3(0, 0, -90), Time.deltaTime));
            else
                t.rotation = Quaternion.Euler(Vector3.Lerp(t.rotation.eulerAngles, new Vector3(0, 0, 270), Time.deltaTime));
        }
        if (Input.GetKey(WASD ? KeyCode.S : KeyCode.K)) {
            if (t.rotation.eulerAngles.z <= 180)
                t.rotation = Quaternion.Euler(Vector3.Lerp(t.rotation.eulerAngles, new Vector3(0, 0, 0), Time.deltaTime));
            else
                t.rotation = Quaternion.Euler(Vector3.Lerp(t.rotation.eulerAngles, new Vector3(0, 0, 360), Time.deltaTime));
        }
        if (Input.GetKey(WASD ? KeyCode.D : KeyCode.L)) {
            if (t.rotation.eulerAngles.z <= 270) // I HATE YOU!
                t.rotation = Quaternion.Euler(Vector3.Lerp(t.rotation.eulerAngles, new Vector3(0, 0, 90), Time.deltaTime));
            else
                t.rotation = Quaternion.Euler(Vector3.Lerp(t.rotation.eulerAngles, new Vector3(0, 0, -270), Time.deltaTime));
        }
    }

    void Reset() {
        RightArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        RightArmLower.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        LeftArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        LeftArmLower.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
}
