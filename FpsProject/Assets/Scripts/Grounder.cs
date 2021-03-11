using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Grounder : MonoBehaviour
{
    public bool IsGrounded { get; private set; } = true;
    
    private void OnTriggerEnter(Collider other)
    {
        IsGrounded = true;
    }

    private void OnTriggerExit(Collider other)
    {
        IsGrounded = false;
    }

    // Not necessary, its just to be shure
    private void OnTriggerStay(Collider other)
    {
        IsGrounded = true;
    }
}