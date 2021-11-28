using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletParticleLifeTime : MonoBehaviour
{
    float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > startTime + 0.1f) { Destroy(gameObject); }
    }
}
