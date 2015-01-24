using UnityEngine;
using System.Collections;

public class ParachuteContainer : MonoBehaviour {

    Parachute parachuteScript;
    GameObject parachute;

    public void EquipParachute(GameObject parachute, Parachute parachuteScript)
    {
        this.parachuteScript = parachuteScript;
        this.parachute = parachute;
        parachuteScript.enabled = false;
        parachute.rigidbody2D.isKinematic = true;
        parachute.collider2D.enabled = false;
        parachute.transform.parent = transform;
        parachute.transform.localPosition = Vector3.zero;
        parachute.transform.localEulerAngles = Vector3.zero;
    }

    public void UnEquipParachute()
    {
        parachute.transform.parent = null;
        parachute.transform.Translate(new Vector3(0, 10, 0));
        parachute.collider2D.enabled = true;
        parachute.rigidbody2D.isKinematic = false;
        parachuteScript.enabled = true;
        this.parachuteScript = null;
        this.parachute = null;
    }
}
