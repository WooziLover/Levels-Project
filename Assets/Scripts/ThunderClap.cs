using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderClap : MonoBehaviour
{
    new Light light;
    public AudioClip clip;
    AudioSource audioSource;
    bool canFlicker = true;

    void Start()
    {
        light = GetComponent<Light>();
        audioSource = GetComponent<AudioSource>();
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
            audioSource.PlayOneShot(clip, 0.7f);
            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(0.1f, 0.4f));
            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(0.1f, 5));
            canFlicker = true;
        }
    }
}
