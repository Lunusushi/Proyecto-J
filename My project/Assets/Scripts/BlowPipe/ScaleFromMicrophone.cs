using UnityEngine;

public class ScaleFromMicrophone : MonoBehaviour
{
    public Vector3 minScale, maxScale;
    public AudioLoudnessDetection detector;

    public float loudnessSensibility = 100;
    public float threshold = 0.1f;
    public float smoothingFactor = 0.1f;
    private float smoothedLoudness = 0;
    public float scaleStep = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone()* loudnessSensibility;

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