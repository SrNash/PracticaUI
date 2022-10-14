using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AddingForces : MonoBehaviour
{
    [SerializeField]
    Vector3 forceTo;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
            rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DesiredTopDown(float v)
    {
        Vector3 direction = new Vector3(0f, v, 0f);
        rb.AddForce(direction, ForceMode.Impulse);
    }
    public void DesiredLeftRight(float h)
    {
        Vector3 direction = new Vector3(h, 0f, 0f);
        rb.AddForce(direction, ForceMode.Impulse);
    }

    public void AddForceToRB()
    {
        rb.AddForce(forceTo, ForceMode.Impulse);
    }

    public void AddForcesToRB(Vector3 force)
    {
        rb.AddForce(force, ForceMode.Impulse);
    }

}
