using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    // Start is called before the first frame update
    public float propellerRotation = 100.0f;
    public float rotationSpeed = 100.0f;
    private Vector3 spinZ = new Vector3(0, 0, 1);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinZ * rotationSpeed * propellerRotation);
    }
}
