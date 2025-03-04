using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class RotationController : MonoBehaviour
{
    public GameObject PlanetObject;
    public Vector3 RotationVector;

    private void Update()
    {
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}