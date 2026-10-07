using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var newPose = new Vector3(target.position.z, transform.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, newPose, t: Time.deltaTime * 10);
    }
}
