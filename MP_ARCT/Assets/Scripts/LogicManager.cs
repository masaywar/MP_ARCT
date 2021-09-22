using System.Net.WebSockets;
using System.Net;
using System;
using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class LogicManager : MonoBehaviour
{
    [SerializeField] private bool isLive;

    [SerializeField] private ARSession _arSession;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _spawnedPrefab;
    [SerializeField] private ARRaycastManager _arRaycastManager;
    [SerializeField] private ARPlaneManager _arPlaneManager;


    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private void Awake()
    {

        if (TryInitialize())
        {
            print("Error in initialize LogicManager");
        }
    }


    private void Update()
    {
        if (isLive)
        {
            if (Input.touchCount > 0)
            {
                OnScreenTouch();
            }
        }

    }

    private bool TryInitialize()
    {
        _arSession = GetComponent<ARSession>();
        return _arSession.Equals(null) || _arPlaneManager.Equals(null) || _arPlaneManager.Equals(null);
    }

    public void SetPlaneDetection(bool set)
    {
        _arPlaneManager.enabled = set;
    }

    private void OnScreenTouch()
    {
        Touch touch = Input.GetTouch(0);
        Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
        Ray ray = Camera.main.ScreenPointToRay(touchPos);

        if (touch.phase == TouchPhase.Began)
        {
            if (_spawnedPrefab.Equals(null))
            {
                if (_arRaycastManager.Raycast(ray, hits, TrackableType.PlaneWithinPolygon))
                {
                    Pose hitPose = hits[0].pose;
                    Spawn(hitPose.position);
                }
            }
            else
            {
                // if (Physics.Raycast(ray, out var hit))
                // {
                //     if (hit.collider.gameObject.CompareTag("Selectable"))                    
                //     OnTouchObject(hit.collider.gameObject);
                // }
            }
        }
    }

    private void Spawn(Vector3 pos)
    {
        _spawnedPrefab = Instantiate(_prefab);
        _spawnedPrefab.SetActive(true);
        _spawnedPrefab.transform.SetPositionAndRotation(pos, Quaternion.identity);
    }

    private void OnTouchObject(GameObject selected)
    {
        
    }
}
