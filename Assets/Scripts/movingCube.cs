using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingCube : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private Vector3 endPosition;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, Mathf.PingPong(Time.time * speed, 1));
    }
}
