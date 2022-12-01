using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    Text fpsText;

    [SerializeField]
    Text memoryText;

    [SerializeField]
    float updateInterval = 0.05f; // update every 0.05 seconds

    float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.unscaledDeltaTime;

        if (currentTime > updateInterval)
        {
            currentTime = 0;

            float fps = 0;
            if (Time.unscaledDeltaTime != 0)
                fps = 1 / Time.unscaledDeltaTime;

            float memory = UnityEngine.Profiling.Profiler.GetTotalAllocatedMemoryLong() / 1000000; // get memory usage and convert to megabytes

            fpsText.text = (int)fps + " FPS";
            memoryText.text = "Memory: " + memory + " MB";
        }

    }
}
