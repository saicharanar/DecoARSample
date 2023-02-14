using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TrackedImageActionController : MonoBehaviour
{
    
    [SerializeField] private RectTransform canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        var scale = 0.0001f;
        var height =  ImageTracker.Instance.currentImageSize.x;
        var width = ImageTracker.Instance.currentImageSize.y;
        
        canvas.localScale = new Vector2(scale, scale);
        canvas.sizeDelta = new Vector2(height * 10000, width * 10000);
    }
}
