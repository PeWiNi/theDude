using UnityEngine;
using System.Collections;

public class IncantationPosing : MonoBehaviour {
    public float leeway = 20;
    Rotate character;
    incant current = incant.none;
	// Use this for initialization
	void Start () {
        character = GameObject.Find("hero").GetComponentInChildren<Rotate>();

        print("0, 0 : true | " + checker(0, 0));
        print("359, 0 : true | " + checker(359, 0));
        print("359, 15 : true | " + checker(359, 15));
        print("0, 25 : false | " + checker(0, 25));
        print("359, 25 : false | " + checker(359, 25));
        print("0, 350 : true | " + checker(0, 350));
        print("30, 45 : true | " + checker(30, 45));
        print("330, 5 : false | " + checker(330, 5));
    }
	enum incant {
        A1, A2, B1, B2, C1, C2, D1, D2, none
    }
	// Update is called once per frame
	void Update () {
        if (current == incant.A1)
            setA1(true);
	}

    bool checker(float actualAngle, float requiredAngle) {
        return Mathf.Min((actualAngle - requiredAngle + 360) % 360, (requiredAngle - actualAngle + 360) % 360) <= leeway;
    }

    bool incA1() {
        bool isRight = true;
        isRight = checker(character.RightArm.rotation.eulerAngles.z, 90);
        isRight = checker(character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z, 90);
        isRight = checker(character.LeftArm.rotation.eulerAngles.z, 270);
        isRight = checker(character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z, 90);

        isRight = checker(character.RightLeg.rotation.eulerAngles.z, 45);
        isRight = checker(character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z, 315);
        isRight = checker(character.LeftLeg.rotation.eulerAngles.z, 0);
        isRight = checker(character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z, 0);
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

    public void setA1(bool lerp) {
        current = lerp ? incant.A1 : incant.none;
        character.RightArm.rotation = lerp ? Quaternion.Euler(Vector3.Lerp(character.RightArm.rotation.eulerAngles, new Vector3(0, 0, 90), Time.deltaTime)) : 
            Quaternion.Euler(new Vector3(0, 0, 90));
        character.RightArm.GetChild(0).transform.localRotation = lerp ? 
            Quaternion.Euler(Vector3.Lerp(character.RightArm.GetChild(0).transform.localRotation.eulerAngles, new Vector3(0, 0, 90), Time.deltaTime)) : 
            Quaternion.Euler(new Vector3(0, 0, 90));
        character.LeftArm.rotation = lerp ? Quaternion.Euler(Vector3.Lerp(character.LeftArm.rotation.eulerAngles, new Vector3(0, 0, 270), Time.deltaTime)) : 
            Quaternion.Euler(new Vector3(0, 0, 270));
        character.LeftArm.GetChild(0).transform.localRotation = lerp ?
            Quaternion.Euler(Vector3.Lerp(character.LeftArm.GetChild(0).transform.localRotation.eulerAngles, new Vector3(0, 0, 90), Time.deltaTime)) : 
            Quaternion.Euler(new Vector3(0, 0, 90));

        character.RightLeg.rotation = lerp ? Quaternion.Euler(Vector3.Lerp(character.RightLeg.rotation.eulerAngles, new Vector3(0, 0, 45), Time.deltaTime)) : 
            Quaternion.Euler(new Vector3(0, 0, 45));
        character.RightLeg.GetChild(0).transform.localRotation = lerp ?
            Quaternion.Euler(Vector3.Lerp(character.RightLeg.GetChild(0).transform.localRotation.eulerAngles, new Vector3(0, 0, 315), Time.deltaTime)) : 
            Quaternion.Euler(new Vector3(0, 0, 315));
        character.LeftLeg.rotation = lerp ? Quaternion.Euler(Vector3.Lerp(character.LeftLeg.rotation.eulerAngles, new Vector3(0, 0, 0), Time.deltaTime)) : 
            Quaternion.Euler(new Vector3(0, 0, 0));
        character.LeftLeg.GetChild(0).transform.localRotation = lerp ?
            Quaternion.Euler(Vector3.Lerp(character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles, new Vector3(0, 0, 0), Time.deltaTime)) : 
            Quaternion.Euler(new Vector3(0, 0, 0));
    }

    bool incA2() {
        bool isRight = true;
        isRight = checker(character.RightArm.rotation.eulerAngles.z, 90);
        isRight = checker(character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z, 270);
        isRight = checker(character.LeftArm.rotation.eulerAngles.z, 270);
        isRight = checker(character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z, 270);

        isRight = checker(character.RightLeg.rotation.eulerAngles.z, 0);
        isRight = checker(character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z, 0);
        isRight = checker(character.LeftLeg.rotation.eulerAngles.z, 315);
        isRight = checker(character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z, 45);
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
        isRight = checker(character.RightArm.rotation.eulerAngles.z, 110);
        isRight = checker(character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z, 70);
        isRight = checker(character.LeftArm.rotation.eulerAngles.z, 250);
        isRight = checker(character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z, 290);

        isRight = checker(character.RightLeg.rotation.eulerAngles.z, 0);
        isRight = checker(character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z, 0);
        isRight = checker(character.LeftLeg.rotation.eulerAngles.z, 0);
        isRight = checker(character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z, 0);
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
        isRight = checker(character.RightArm.rotation.eulerAngles.z, 70);
        isRight = checker(character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z, 290);
        isRight = checker(character.LeftArm.rotation.eulerAngles.z, 290);
        isRight = checker(character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z, 70);

        isRight = checker(character.RightLeg.rotation.eulerAngles.z, 0);
        isRight = checker(character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z, 0);
        isRight = checker(character.LeftLeg.rotation.eulerAngles.z, 0);
        isRight = checker(character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z, 0);
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
        isRight = checker(character.RightArm.rotation.eulerAngles.z, 90);
        isRight = checker(character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z, 90);
        isRight = checker(character.LeftArm.rotation.eulerAngles.z, 270);
        isRight = checker(character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z, 270);

        isRight = checker(character.RightLeg.rotation.eulerAngles.z, 90);
        isRight = checker(character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z, 270);
        isRight = checker(character.LeftLeg.rotation.eulerAngles.z, 270);
        isRight = checker(character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z, 90);
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
        isRight = checker(character.RightArm.rotation.eulerAngles.z, 90);
        isRight = checker(character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z, 90);
        isRight = checker(character.LeftArm.rotation.eulerAngles.z, 270);
        isRight = checker(character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z, 270);

        isRight = checker(character.RightLeg.rotation.eulerAngles.z, 45);
        isRight = checker(character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z, 315);
        isRight = checker(character.LeftLeg.rotation.eulerAngles.z, 315);
        isRight = checker(character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z, 45);
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
        isRight = checker(character.RightArm.rotation.eulerAngles.z, 135);
        isRight = checker(character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z, 45);
        isRight = checker(character.LeftArm.rotation.eulerAngles.z, 135);
        isRight = checker(character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z, 45);

        isRight = checker(character.RightLeg.rotation.eulerAngles.z, 0);
        isRight = checker(character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z, 0);
        isRight = checker(character.LeftLeg.rotation.eulerAngles.z, 270);
        isRight = checker(character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z, 0);
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
        isRight = checker(character.RightArm.rotation.eulerAngles.z, 135);
        isRight = checker(character.RightArm.GetChild(0).transform.localRotation.eulerAngles.z, 45);
        isRight = checker(character.LeftArm.rotation.eulerAngles.z, 135);
        isRight = checker(character.LeftArm.GetChild(0).transform.localRotation.eulerAngles.z, 45);

        isRight = checker(character.RightLeg.rotation.eulerAngles.z, 90);
        isRight = checker(character.RightLeg.GetChild(0).transform.localRotation.eulerAngles.z, 0);
        isRight = checker(character.LeftLeg.rotation.eulerAngles.z, 0);
        isRight = checker(character.LeftLeg.GetChild(0).transform.localRotation.eulerAngles.z, 0);
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
