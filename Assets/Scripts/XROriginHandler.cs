using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class XROriginHandler : MonoBehaviour
{
    [SerializeField]
    public ARTrackedImageManager imageManager; // Riferimento all'oggetto dell'immagine riconosciuta
    [SerializeField]
    public GameObject canvas; // Riferimento al Canvas che vuoi posizionare
    
    void OnEnable()
    {
        // Assicurati di avere un riferimento al componente ARTrackedImageManager
        if (imageManager != null)
        {
            imageManager.trackedImagesChanged += OnTrackedImagesChanged;
        }
    }

    void OnDisable()
    {
        if (imageManager != null)
        {
            imageManager.trackedImagesChanged -= OnTrackedImagesChanged;
        }
    }
    

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            canvas.transform.position =  trackedImage.transform.position;
        }
    }
}
