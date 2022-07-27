using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


[RequireComponent(typeof(ARRaycastManager))]

public class PlacementController : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObjectToPlace;


    public GameObject PlacedPrefab
    {
        get
        {
            return gameObjectToPlace;
        }

        set
        {
            gameObjectToPlace = value;
        }
    }

    private ARRaycastManager arRaycastManager;

    void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
    }


    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;
        return false;
    }


    // Update is called once per frame
    void Update()
    {
        if(!TryGetTouchPosition(out Vector2 touchPosition))
        {
            return;
        }

        if (arRaycastManager.Raycast(touchPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        {
            var hitPosition = hits[0].pose;

            Instantiate(gameObjectToPlace, hitPosition.position, hitPosition.rotation);
        }
    }

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
}
