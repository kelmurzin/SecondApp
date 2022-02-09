using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector3 _lastVelosity;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _lastVelosity = _rb.velocity;
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Wall")
        {
            var speed = _lastVelosity.magnitude;
            var dir = Vector3.Reflect(_lastVelosity.normalized, coll.contacts[0].normal);            
            _rb.velocity = dir * Mathf.Max(speed, 6);
           
        }
    }
}
