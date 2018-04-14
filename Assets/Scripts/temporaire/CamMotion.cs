using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMotion : MonoBehaviour {

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    // Use this for initialization
    void Update () {

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
            if (Input.GetAxis("Mouse X") > 0f)
                transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            if (Input.GetAxis("Mouse X") < 0f)
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            if (Input.GetAxis("Mouse Y") > 0f)
                transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            if (Input.GetAxis("Mouse Y") < 0f)
                transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
    }
}
