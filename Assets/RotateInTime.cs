using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RotateInTime : MonoBehaviour {
    void Awake() {
        transform.Rotate(-new Vector3(0, 0, 1), Random.Range(0,360));
    }

    void Update() {
        transform.Rotate(-new Vector3(0, 0, 1), Time.deltaTime*180);
    }
}