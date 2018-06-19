using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircadianManager : MonoBehaviour {

    // Use this for initialization

    [SerializeField]
    private float intensityChange = 0.1f;
    [SerializeField]
    private float minLight = 0.1f;
    [SerializeField]
    private float maxLight = 1.0f;

    private bool isGettingBrighter = true;

    Light sun;

	void Start () {
        sun = GetComponent<Light>();
        sun.intensity = minLight;
	}
	
	// Update is called once per frame
	void Update () {

        if (sun.intensity >= maxLight)
            isGettingBrighter = false;
        else if (sun.intensity <= minLight)
            isGettingBrighter = true;

        if (isGettingBrighter)
        {
            sun.intensity += intensityChange * Time.deltaTime;
        }
        else
            sun.intensity -= intensityChange * Time.deltaTime;
    }
}
