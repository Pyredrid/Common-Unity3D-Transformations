﻿using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
    public bool fireOnce = false;
    public bool shouldRealign = true;
    public float speed = 1.0f;
    public float amount = 360.0f;
    public Vector3 axis = Vector3.up;
    public AnimationCurve curve;

    private float t = 0.0f;
    private Vector3 start;
    private Vector3 end;

    void Start () {
        Align();
    }

    void Align () {
        if(!shouldRealign) {
            return;
        }
        start = transform.rotation.eulerAngles;

        Vector3 offset = axis * amount;
        offset *= curve.Evaluate(1.0f);
        end = start + offset;
    }

    void Update () {
        float dt = Time.deltaTime * speed;
        t += dt;
        if(t >= 1.0f) {
            if(fireOnce) {
                transform.rotation = Quaternion.Euler(start);
                enabled = false;
                return;
            }
            t = 0.0f;
            Align();
        }
        float cs = curve.Evaluate(t);
        Vector3 rot =  Vector3.Lerp(start, end, cs);
        transform.rotation = Quaternion.Euler(rot);
    }

    public void SetSpeed (int speed) {
        this.speed = speed;
    }
}
