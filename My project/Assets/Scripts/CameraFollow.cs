using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    void Update()
    {
        var direction = (_target.position - transform.position).normalized;
        transform.forward = direction;
    }
}
