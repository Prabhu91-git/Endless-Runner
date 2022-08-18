using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_control : MonoBehaviour
{
    public Transform player;
    Vector3 offset,target;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        target = player.position + offset;
        target.x = 0;
        transform.position = target;
    }
}
