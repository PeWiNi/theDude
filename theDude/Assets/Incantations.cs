using UnityEngine;
using System.Collections;

public class Incantations : MonoBehaviour {
    Rotate character;

	// Use this for initialization
	void Start () {
        character = GameObject.Find("hero").GetComponentInChildren<Rotate>();
    }
	enum incant {
        A1, A2, B1, B2, C1, C2, D1, D2
    }
	// Update is called once per frame
	void Update () {
	    
	}

    bool incA1() {
        bool isRight = true;
        isRight = character.RightArm.rotation.eulerAngles.z == 90;
        isRight = character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z == 90;
        isRight = character.LeftArm.rotation.eulerAngles.z == 270;
        isRight = character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z == 90;

        isRight = character.RightLeg.rotation.eulerAngles.z == 45;
        isRight = character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z == 315;
        isRight = character.LeftLeg.rotation.eulerAngles.z == 0;
        isRight = character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z == 0;
        return isRight;
    }

    public void setA1() {
        character.RightArm.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
        character.RightArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
        character.LeftArm.rotation = Quaternion.Euler(new Vector3(0, 0, 270));
        character.LeftArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));

        character.RightLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 45));
        character.RightLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 315));
        character.LeftLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.LeftLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    bool incA2() {
        bool isRight = true;
        isRight = character.RightArm.rotation.eulerAngles.z == 90;
        isRight = character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z == 270;
        isRight = character.LeftArm.rotation.eulerAngles.z == 270;
        isRight = character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z == 270;

        isRight = character.RightLeg.rotation.eulerAngles.z == 0;
        isRight = character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z == 0;
        isRight = character.LeftLeg.rotation.eulerAngles.z == 315;
        isRight = character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z == 45;
        return isRight;
    }

    public void setA2() {
        character.RightArm.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
        character.RightArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 270));
        character.LeftArm.rotation = Quaternion.Euler(new Vector3(0, 0, 270));
        character.LeftArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 270));

        character.RightLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.RightLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.LeftLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 315));
        character.LeftLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 45));
    }

    bool incB1() {
        bool isRight = true;
        isRight = character.RightArm.rotation.eulerAngles.z == 110;
        isRight = character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z == 70;
        isRight = character.LeftArm.rotation.eulerAngles.z == 250;
        isRight = character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z == 290;

        isRight = character.RightLeg.rotation.eulerAngles.z == 0;
        isRight = character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z == 0;
        isRight = character.LeftLeg.rotation.eulerAngles.z == 0;
        isRight = character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z == 0;
        return isRight;
    }

    public void setB1() {
        character.RightArm.rotation = Quaternion.Euler(new Vector3(0, 0, 110));
        character.RightArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 70));
        character.LeftArm.rotation = Quaternion.Euler(new Vector3(0, 0, 250));
        character.LeftArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 290));

        character.RightLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.RightLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.LeftLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.LeftLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    bool incB2() {
        bool isRight = true;
        isRight = character.RightArm.rotation.eulerAngles.z == 70;
        isRight = character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z == 290;
        isRight = character.LeftArm.rotation.eulerAngles.z == 290;
        isRight = character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z == 70;

        isRight = character.RightLeg.rotation.eulerAngles.z == 0;
        isRight = character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z == 0;
        isRight = character.LeftLeg.rotation.eulerAngles.z == 0;
        isRight = character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z == 0;
        return isRight;
    }

    public void setB2() {
        character.RightArm.rotation = Quaternion.Euler(new Vector3(0, 0, 70));
        character.RightArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 290));
        character.LeftArm.rotation = Quaternion.Euler(new Vector3(0, 0, 290));
        character.LeftArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 70));

        character.RightLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.RightLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.LeftLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.LeftLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    bool incC1() {
        bool isRight = true;
        isRight = character.RightArm.rotation.eulerAngles.z == 90;
        isRight = character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z == 90;
        isRight = character.LeftArm.rotation.eulerAngles.z == 270;
        isRight = character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z == 270;

        isRight = character.RightLeg.rotation.eulerAngles.z == 90;
        isRight = character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z == 270;
        isRight = character.LeftLeg.rotation.eulerAngles.z == 270;
        isRight = character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z == 90;
        return isRight;
    }

    public void setC1() {
        character.RightArm.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
        character.RightArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
        character.LeftArm.rotation = Quaternion.Euler(new Vector3(0, 0, 270));
        character.LeftArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 270));

        character.RightLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
        character.RightLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 270));
        character.LeftLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 270));
        character.LeftLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
    }

    bool incC2() {
        bool isRight = true;
        isRight = character.RightArm.rotation.eulerAngles.z == 90;
        isRight = character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z == 90;
        isRight = character.LeftArm.rotation.eulerAngles.z == 270;
        isRight = character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z == 270;

        isRight = character.RightLeg.rotation.eulerAngles.z == 45;
        isRight = character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z == 315;
        isRight = character.LeftLeg.rotation.eulerAngles.z == 315;
        isRight = character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z == 45;
        return isRight;
    }

    public void setC2() {
        character.RightArm.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
        character.RightArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
        character.LeftArm.rotation = Quaternion.Euler(new Vector3(0, 0, 270));
        character.LeftArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 270));

        character.RightLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 45));
        character.RightLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 315));
        character.LeftLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 315));
        character.LeftLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 45));
    }

    bool incD1() {
        bool isRight = true;
        isRight = character.RightArm.rotation.eulerAngles.z == 135;
        isRight = character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z == 45;
        isRight = character.LeftArm.rotation.eulerAngles.z == 135;
        isRight = character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z == 45;

        isRight = character.RightLeg.rotation.eulerAngles.z == 0;
        isRight = character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z == 0;
        isRight = character.LeftLeg.rotation.eulerAngles.z == 270;
        isRight = character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z == 0;
        return isRight;
    }

    public void setD1() {
        character.RightArm.rotation = Quaternion.Euler(new Vector3(0, 0, 135));
        character.RightArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 45));
        character.LeftArm.rotation = Quaternion.Euler(new Vector3(0, 0, 135));
        character.LeftArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 45));

        character.RightLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.RightLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.LeftLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 270));
        character.LeftLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    bool incD2() {
        bool isRight = true;
        isRight = character.RightArm.rotation.eulerAngles.z == 135;
        isRight = character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z == 45;
        isRight = character.LeftArm.rotation.eulerAngles.z == 135;
        isRight = character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z == 45;

        isRight = character.RightLeg.rotation.eulerAngles.z == 90;
        isRight = character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z == 0;
        isRight = character.LeftLeg.rotation.eulerAngles.z == 0;
        isRight = character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z == 0;
        return isRight;
    }

    public void setD2() {
        character.RightArm.rotation = Quaternion.Euler(new Vector3(0, 0, 135));
        character.RightArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 45));
        character.LeftArm.rotation = Quaternion.Euler(new Vector3(0, 0, 135));
        character.LeftArm.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 45));

        character.RightLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
        character.RightLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.LeftLeg.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        character.LeftLeg.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
}
