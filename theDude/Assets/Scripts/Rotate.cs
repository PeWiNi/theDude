using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    Transform RightArm; // IJKL
    Transform LeftArm; // WASD
    Transform RightLeg; // IJKL
    Transform LeftLeg; // WASD
    float doomTimer;
    float nextActionTime = 10;
    float time;

    // Use this for initialization
    void Start () {
        RightArm = GameObject.Find("RightArm").transform;
        LeftArm = GameObject.Find("LeftArm").transform;
        RightLeg = GameObject.Find("RightLeg").transform;
        LeftLeg = GameObject.Find("LeftLeg").transform;
        Reset();
        doomTimer = 1;
    }
	
	// Update is called once per frame
	void Update () {
        time = Time.deltaTime * doomTimer;
        if (Input.GetKeyDown(KeyCode.R)) {
            Reset();
        }
        RotationInputManager(RightArm, false);
        RotationInputManager(LeftArm, true);
        BendKnees(RightLeg, false);
        BendKnees(LeftLeg, true);

        if (Time.time > nextActionTime) {
            nextActionTime += 10; doomTimer += .1f;
        }
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
        Vector3 rot = new Vector3();
        if ((WASD ? Input.GetAxis("Vertical") : Input.GetAxis("VerticalR")) > 0) {//.GetKey(WASD ? KeyCode.W : KeyCode.I)) {
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
        if ((WASD ? Input.GetAxis("Vertical") : Input.GetAxis("VerticalR")) < 0) {//Input.GetKey(WASD ? KeyCode.S : KeyCode.K)) {
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
                0, 0, Mathf.Lerp(Arm.GetChild(0).transform.localRotation.eulerAngles.z, WASD ? 540 : -180, time / 3));
    }

    void BendKnees(Transform Leg, bool left) {
        if (Input.GetButton("moveRightLeg") && !left) { //QE
            Leg.rotation = Quaternion.Euler(Vector3.Lerp(Leg.rotation.eulerAngles,
                new Vector3(0, 0, 90), time * 2));
            float bendy;
            if (Leg.rotation.eulerAngles.z < 85)
                bendy = 270;
            else
                bendy = 359f;
            Leg.GetChild(0).transform.localRotation = Quaternion.Euler(
                0, 0, Mathf.Lerp(Leg.GetChild(0).transform.localRotation.eulerAngles.z, bendy, time * 2));
        }
        if(Input.GetButton("moveLeftLeg") && left) {
            Leg.rotation = Quaternion.Euler(Vector3.Lerp(Leg.rotation.eulerAngles,
                new Vector3(0, 0, 270), time * 2));
            float bendy;
            if (Leg.rotation.eulerAngles.z > 275)
                bendy = 90;
            else
                bendy = 0;
            Leg.GetChild(0).transform.localRotation = Quaternion.Euler(
                0, 0, Mathf.Lerp(Leg.GetChild(0).transform.localRotation.eulerAngles.z, bendy, time * 2));
        }
        if (Input.GetButton(left ? "left" : "right")) { //ZC
            Leg.rotation = Quaternion.Euler(Vector3.Lerp(Leg.rotation.eulerAngles,
                new Vector3(0, 0, left ? 359 : 0), time * 2));
            Leg.GetChild(0).transform.localRotation = Quaternion.Euler(
                0, 0, Mathf.Lerp(Leg.GetChild(0).transform.localRotation.eulerAngles.z, left ? 0 : 359f, time * 2));
        }
    }

    void Reset() {
        RightArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        RightArm.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        LeftArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        LeftArm.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

        RightLeg.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        RightLeg.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(0, 0, 359));
        LeftLeg.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 359));
        LeftLeg.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
}
