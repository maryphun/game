using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Bolt.EntityBehaviour<ICustomCubeState>
{
    //void Start()
    public override void Attached()
    {
        state.SetTransforms(state.CubeTransform, transform);
    }

    //Update() but only called on the owner computer
    public override void SimulateOwner()
    {
        var speed = 4f;
        var movement = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            movement.x -= 1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x += 1f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            movement.z += 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement.z -= 1f;
        }

        if (movement != Vector3.zero)
        {
            transform.position = transform.position + (movement.normalized * speed * BoltNetwork.FrameDeltaTime);
        }
    }
}
