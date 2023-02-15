using System;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.Serialization;

public class TrackedImageActionManager : MonoBehaviour
{
    [Serializable]
    private class Mapper
    {
        public string name;
        public GameObject prefab;
    }

    [SerializeField] private List<Mapper> ImagesWithAction;
    
    private GameObject _instancedPrefab;

    private void Start()
    {
        _instancedPrefab = new GameObject();
    }

    private void OnEnable()
    {
        _instancedPrefab = new GameObject();
        Debug.Log("Sourav :: OnEnabled " + ImageTracker.Instance.currentImage);
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
        GameObject actionPrefab  = ImagesWithAction.Find(img => img.name.Equals(prefabName)).prefab;
        _instancedPrefab = Instantiate(actionPrefab, gameObject.transform.position, actionPrefab.transform.rotation);
        _instancedPrefab.transform.parent = gameObject.transform;
    }
}
