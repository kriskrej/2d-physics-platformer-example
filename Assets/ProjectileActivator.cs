using System;
using UnityEngine;

public class ProjectileActivator : MonoBehaviour {
    [SerializeField] GameObject objectToActivate;

    void Awake() {
        objectToActivate.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other) {
        objectToActivate.SetActive(true);
    }
}