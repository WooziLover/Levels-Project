using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderClap : MonoBehaviour
{
    new Light light;
    bool canFlicker = true;

    void Start()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        StartCoroutine(Flicker());
    }

    IEnumerator Flicker()
    {
        if (canFlicker)
        {
            canFlicker = false;

            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(0.1f, 0.4f));
            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(0.1f, 5));
            canFlicker = true;
        }
    }
}
