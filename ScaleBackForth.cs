using UnityEngine;
using System.Collections;

public class ScaleBackForth : MonoBehaviour {
    public bool fireOnce = false;
    public float speed = 1.0f;
    public float amount = 10.0f;
    public Vector3 axis = Vector3.up;
    public AnimationCurve curve;

    private float t = 0.0f;
    private bool forwards = true;
    private Vector3 start;
    private Vector3 end;

    void Start () {
        start = transform.localScale;

        Vector3 offset = axis * amount;
        offset *= curve.Evaluate(1.0f);
        end = start + offset;
    }

    void Update () {
        float dt = Time.deltaTime * speed;
        t += dt;

        if(forwards) {
            if(t >= 1.0f) {
                t = 0.0f;
                forwards = false;
                transform.localScale = end;
                return;
            }
        } else {
            if(t >= 1.0f) {
                t = 0.0f;
                forwards = true;
                transform.localScale = start;
                if(fireOnce) {
                    enabled = false;
                }
                return;
            }
        }
        float cs = curve.Evaluate(t);
        Vector3 pos;
        if(forwards) {
            pos = Vector3.Lerp(start, end, cs);
        } else {
            pos = Vector3.Lerp(end, start, cs);
        }
        transform.localScale = pos;
    }
}
