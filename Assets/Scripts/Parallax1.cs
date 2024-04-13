
using UnityEngine;

public class Parallax1 : MonoBehaviour
{   
    private Transform cameraTransform;
    private Vector3 previousCameraPosition;
    
    void Start()
    {
       cameraTransform = Camera.main.transform;
       previousCameraPosition = cameraTransform.position;
    }

    void LateUpdate()
    {
        float deltaY = (cameraTransform.position.y - previousCameraPosition.y) * 0.1f;
        transform.Translate(new Vector3(0, deltaY, 0));
        previousCameraPosition = cameraTransform.position;
    }
}
