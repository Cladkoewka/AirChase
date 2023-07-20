using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneController : MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;
    public Animator Animator;
    public AudioSource AirplaneSound;

    private Rigidbody rigidbody;
    private bool isEngineOn;
    private bool isSoundPlay = false;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        isEngineOn = Input.GetKey(KeyCode.W);
        if (isEngineOn && !isSoundPlay) 
        {
            isSoundPlay = true;
            AirplaneSound.Play();
        }
        if (!isEngineOn && isSoundPlay)
        { 
            isSoundPlay = false;
            AirplaneSound.Pause();
        }
    }

    private void FixedUpdate()
    {   
        if (isEngineOn)
        {
            Vector3 force = new Vector3(1, 0.1f, 0);
            rigidbody.AddRelativeForce(force * Speed, ForceMode.VelocityChange);
        }

        float zRotation = Input.GetAxis("Horizontal");
        Vector3 torque = new Vector3(0, 0, -zRotation);
        rigidbody.AddTorque(torque * RotationSpeed, ForceMode.VelocityChange);

        Animator.SetBool("IsEngineOn", isEngineOn);
    }
}
