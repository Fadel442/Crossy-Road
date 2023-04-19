using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField, Range(0, 10)] float speed;

    private void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }
}
