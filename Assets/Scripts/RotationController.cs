using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public Vector3 rot;

    private void Update()
    {
        transform.Rotate(rot * Time.deltaTime);
    }
}
