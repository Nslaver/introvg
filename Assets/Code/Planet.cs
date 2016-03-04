using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Planet : MonoBehaviour
{

    //public GameObject planets;
    float orbit;
    float scale;
    float maxSize = 1.2f;
    float minSize = 0.2f;
    int frequency = 360;

    // Use this for initialization
    void Start()
    {
        orbit = this.transform.position.z;
        scale = Random.Range(minSize, maxSize);
        this.transform.localScale = new Vector3(scale,scale,scale);

    }

    // Update is called once per frame
    void Update()
    {
        float pos = (maxSize - scale) * (Time.realtimeSinceStartup % frequency);
        this.transform.position = new Vector3(orbit*Mathf.Sin(pos), 0, orbit * Mathf.Cos(pos));
        //this.transform.Rotate(Vector3.forward * 0.1f);
    }
}