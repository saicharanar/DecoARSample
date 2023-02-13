using System;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class TrackedImageController : MonoBehaviour
{
    [Serializable]
    private class Mapper
    {
        public string name;
        public GameObject prefab;
    }

    [SerializeField] private List<Mapper> images;
    private GameObject _instancedPrefab;

    private void Start()
    {
        _instancedPrefab = new GameObject();
    }

    private void OnEnable()
    {
        _instancedPrefab = new GameObject();
        Debug.Log("ImageTracked Enabled");
        StartCoroutine(InstancePrefab());
    }
    
    private void OnDisable()
    {
        Destroy(_instancedPrefab);
    }

    public IEnumerator InstancePrefab()
    {
        yield return new WaitForSeconds(2f);
        var prefabName = ImageTracker.Instance.currentImage;
        GameObject prefab  = images.Find(img => img.name.Equals(prefabName)).prefab;
        _instancedPrefab = Instantiate(prefab, gameObject.transform.position, prefab.transform.rotation);
        _instancedPrefab.transform.parent = gameObject.transform;
        // if (_instancedPrefab.GetChildGameObjects() is not null) {
        //     var height = -0.0989f;
        //     var width = -0.14f;
        //     _instancedPrefab.transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);
        //     _instancedPrefab.transform.position = new Vector3(height, width);
        //
        // }
    }
}
