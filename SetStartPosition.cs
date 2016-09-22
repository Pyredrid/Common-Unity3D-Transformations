using UnityEngine;
using System.Collections;

public class SetStartPosition : MonoBehaviour {
    public Vector3 start;
    public bool isLocal = true;

	void Start () {
        if(isLocal) {
            transform.localPosition = start;
        } else {
            transform.position = start;
        }
    }
}
