using UnityEngine;
using System.Collections;

public class RotationRandomness : MonoBehaviour {
    public float xRandomness;
    public float yRandomness;
    public float zRandomness;

    void Awake () {
        float rX = Random.Range(-xRandomness, xRandomness);
        float rY = Random.Range(-yRandomness, yRandomness);
        float rZ = Random.Range(-yRandomness, yRandomness);
        Vector3 rot = transform.eulerAngles;
        rot.x += rX;
        rot.y += rY;
        rot.z += rZ;
        transform.eulerAngles = rot;
    }
}
