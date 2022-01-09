using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTracking : MonoBehaviour
{
    public GameObject player;
    Vector3 distance;

    private void Start()
    {
        distance = transform.position - player.transform.position;
    }
    private void Update()
    {
        transform.position = player.transform.position + distance;
    }
}
