using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pointer : MonoBehaviour
{
    public float defaultLenght = 5.0f;
    public GameObject dot;
    public VRInputModule inputModule;

    private LineRenderer lineRenderer;

    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();

    }


    void Update()
    {
        UpdateLine();
    }

    public void UpdateLine()
    {
        PointerEventData data = inputModule.GetData();
        float targetLenght = data.pointerCurrentRaycast.distance == 0 ? defaultLenght : data.pointerCurrentRaycast.distance;

        RaycastHit hit = CreateRaycast(targetLenght);
        Vector3 endPosition = transform.position + (transform.forward * targetLenght);
        if (hit.collider != null)
            endPosition = hit.point;

        dot.transform.position = endPosition;

        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, endPosition);

    }

    private RaycastHit CreateRaycast(float length)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, defaultLenght);
        return hit;
    }
}
