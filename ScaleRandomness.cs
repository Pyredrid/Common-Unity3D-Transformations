using UnityEngine;
using System.Collections;

public class ScaleRandomness : MonoBehaviour {
    public float xRandomness;
    public float yRandomness;
    public float zRandomness;

    void Awake () {
        float rX = Random.Range(-xRandomness, xRandomness);
        float rY = Random.Range(-yRandomness, yRandomness);
        float rZ = Random.Range(-yRandomness, yRandomness);
        Vector3 scl = transform.localScale;
        scl.x += rX;
        scl.y += rY;
        scl.z += rZ;
        transform.localScale = scl;
    }
}
