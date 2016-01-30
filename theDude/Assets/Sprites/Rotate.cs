using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    Transform RightArm; // IJKL
    Transform LeftArm; // WASD


    // Use this for initialization
    void Start () {
        RightArm = GameObject.Find("RightArm").transform;
        LeftArm = GameObject.Find("LeftArm").transform;
        Reset();
    }
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.R)) {
            Reset();
        }
        RotationInputManager(RightArm, false);
        RotationInputManager(LeftArm, true);
    }

    void Rotation(Transform Arm, bool WASD) { //Alt to WASD is IJKL
        float time = Time.deltaTime * 3;
        Vector3 rot = new Vector3();
        if (Input.GetKey(WASD ? KeyCode.W : KeyCode.I)) {
            rot = new Vector3(0, 0, 180);

            Arm.rotation = Quaternion.Euler(Vector3.Lerp(Arm.rotation.eulerAngles,
                rot, time));
        }
        if (Input.GetKey(WASD ? KeyCode.A : KeyCode.J)) {
            if (Arm.rotation.eulerAngles.z <= 90) 
                rot = new Vector3(0, 0, -90);
            else 
                rot = new Vector3(0, 0, 270);

            Arm.rotation = Quaternion.Euler(Vector3.Lerp(Arm.rotation.eulerAngles,
                rot, time));
        }
        if (Input.GetKey(WASD ? KeyCode.S : KeyCode.K)) {
            if (Arm.rotation.eulerAngles.z <= 180)
                rot = new Vector3(0, 0, 0);
            else
                rot = new Vector3(0, 0, 360);

            Arm.rotation = Quaternion.Euler(Vector3.Lerp(Arm.rotation.eulerAngles,
                rot, time));
        }
        if (Input.GetKey(WASD ? KeyCode.D : KeyCode.L)) {
            if (Arm.rotation.eulerAngles.z <= 270)
                rot = new Vector3(0, 0, 90);
            else 
                rot = new Vector3(0, 0, 450);

            Arm.rotation = Quaternion.Euler(Vector3.Lerp(Arm.rotation.eulerAngles,
                rot, time));
        }

        if(!rot.Equals(new Vector3()))
            Arm.GetChild(0).transform.localRotation = Quaternion.Euler(
                0, 0, Mathf.Lerp(Arm.GetChild(0).transform.localRotation.eulerAngles.z, WASD ? 540 : -180, time / 2));
    }

    void RotationInputManager(Transform Arm, bool WASD) {
        float time = Time.deltaTime * 3;
        Vector3 rot = new Vector3();
        if ((WASD ? Input.GetAxis("Vertical") : Input.GetAxis("VerticalR")) < 0) {//.GetKey(WASD ? KeyCode.W : KeyCode.I)) {
            rot = new Vector3(0, 0, 180);

            Arm.rotation = Quaternion.Euler(Vector3.Lerp(Arm.rotation.eulerAngles,
                rot, time));
        }
        if ((WASD ? Input.GetAxis("Horizontal") : Input.GetAxis("HorizontalR")) < 0) {//Input.GetKey(WASD ? KeyCode.A : KeyCode.J)) {
            if (Arm.rotation.eulerAngles.z <= 90)
                rot = new Vector3(0, 0, -90);
            else
                rot = new Vector3(0, 0, 270);

            Arm.rotation = Quaternion.Euler(Vector3.Lerp(Arm.rotation.eulerAngles,
                rot, time));
        }
        if ((WASD ? Input.GetAxis("Vertical") : Input.GetAxis("VerticalR")) > 0) {//Input.GetKey(WASD ? KeyCode.S : KeyCode.K)) {
            if (Arm.rotation.eulerAngles.z <= 180)
                rot = new Vector3(0, 0, 0);
            else
                rot = new Vector3(0, 0, 360);

            Arm.rotation = Quaternion.Euler(Vector3.Lerp(Arm.rotation.eulerAngles,
                rot, time));
        }
        if ((WASD ? Input.GetAxis("Horizontal") : Input.GetAxis("HorizontalR")) > 0) {//Input.GetKey(WASD ? KeyCode.D : KeyCode.L)) {
            if (Arm.rotation.eulerAngles.z <= 270)
                rot = new Vector3(0, 0, 90);
            else
                rot = new Vector3(0, 0, 450);

            Arm.rotation = Quaternion.Euler(Vector3.Lerp(Arm.rotation.eulerAngles,
                rot, time));
        }

        if (!rot.Equals(new Vector3()))
            Arm.GetChild(0).transform.localRotation = Quaternion.Euler(
                0, 0, Mathf.Lerp(Arm.GetChild(0).transform.localRotation.eulerAngles.z, WASD ? 540 : -180, time / 2));
    }

    void Reset() {
        RightArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        RightArm.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        LeftArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        LeftArm.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
}
