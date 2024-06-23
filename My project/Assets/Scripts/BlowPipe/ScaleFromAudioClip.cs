using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromAudioClip : MonoBehaviour
{

    public AudioSource source;
    public Vector3 minScale, maxScale;
    public AudioLoudnessDetection detector;
    public InternalLogicBot Check;
    public float loudnessSensibility = 100;
    public float threshold = 0.1f;
    public float smoothingFactor = 0.1f;
    private float smoothedLoudness = 0;
    public float scaleStep = 0.1f;
    public bool Alive = true;

    void Start()
    {
        
    }

    void Update()
    {
        if (Check.isExploded == true)
        {
            Alive = false;
        }

        if (Alive)
        {
            float loudness = detector.GetLoudnessFromAudioClip(source.timeSamples, source.clip)* loudnessSensibility;

            if (loudness < threshold)
                loudness = 0;
            
            // Apply smoothing using EMA
            smoothedLoudness = Mathf.Lerp(smoothedLoudness, loudness, smoothingFactor);

            // Calculate the target scale based on smoothed loudness
            Vector3 targetScale = Vector3.Lerp(minScale, maxScale, smoothedLoudness);

            //Lerp value from minscale to maxscale
            transform.localScale = Vector3.MoveTowards(transform.localScale, targetScale, scaleStep * Time.deltaTime);
        }

    }
}
