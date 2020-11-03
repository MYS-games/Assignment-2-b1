using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Tooltip("This is the object that the camera will follow")]
    [SerializeField]
    GameObject toFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(toFollow.gameObject.transform.position.x, toFollow.gameObject.transform.position.y + 3, transform.position.z);

    }
}
