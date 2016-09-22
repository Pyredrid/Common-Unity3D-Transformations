using UnityEngine;
using System.Collections;

public class SetStartRotation : MonoBehaviour {
    public Vector3 start;
    public bool isLocal = true;

    void Start () {
        if(isLocal) {
            transform.localEulerAngles = start;
        } else {
            transform.eulerAngles = start;
        }
    }
}
