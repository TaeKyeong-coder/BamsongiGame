using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamsongiController2 : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    void Start()
    {
        Shoot(new Vector3(0, 100, 1000));
    }

    void Update()
    {

    }
}
