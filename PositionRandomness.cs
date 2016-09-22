using UnityEngine;
using System.Collections;

public class PositionRandomness : MonoBehaviour {
    public float xRandomness;
    public float yRandomness;
    public float zRandomness;

    void Awake () {
        float rX = Random.Range(-xRandomness, xRandomness);
        float rY = Random.Range(-yRandomness, yRandomness);
        float rZ = Random.Range(-yRandomness, yRandomness);
        Vector3 pos = transform.position;
        pos.x += rX;
        pos.y += rY;
        pos.z += rZ;
        transform.position = pos;
    }
}
