using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField] GameObject PlanetObject;
    [SerializeField] Vector3 RotationVector;

    private void Update()
    {
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }


}
