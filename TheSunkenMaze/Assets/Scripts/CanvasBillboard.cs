using UnityEngine;

public class CanvasBillboard : MonoBehaviour
{
    Transform camTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = camTransform.position - transform.position;
    }
}
