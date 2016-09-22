using UnityEngine;
using System.Collections;

public class SetStartScale : MonoBehaviour {
    public Vector3 start;

    void Start () {
        transform.localScale = start;
    }
}
