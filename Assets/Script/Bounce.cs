using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Физика отскока куба.
/// </summary>
public class Bounce : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 _lastVelosity;
    
    private void Start() => rb = GetComponent<Rigidbody>();
    
    private void Update() => _lastVelosity = rb.velocity;
   
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Wall")
        {
            var speed = _lastVelosity.magnitude;
            var dir = Vector3.Reflect(_lastVelosity.normalized, coll.contacts[0].normal);            
            rb.velocity = dir * Mathf.Max(speed, 6);
           
        }
    }
}
