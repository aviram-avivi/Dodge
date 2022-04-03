using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody rigidBD;
    MeshRenderer renderer;
    [SerializeField]float wait_time = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBD = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidBD.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > wait_time)
        {
            renderer.enabled = true;
            rigidBD.useGravity = true;
        }
    }
}
