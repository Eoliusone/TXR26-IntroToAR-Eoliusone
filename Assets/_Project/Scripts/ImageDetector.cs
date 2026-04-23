using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageDetector : MonoBehaviour
{
    private ARTrackedImageManager _trackedImageManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _trackedImageManager = GetComponent<ARTrackedImageManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReactToTrackableChanges(ARTrackedImagesChangedEventArgs eventArgs)
    {
        Debug.Log("ARTrackedImagesChanged");
    }
}
