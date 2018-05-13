using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // https://unity3d.com/fr/learn/tutorials/topics/mobile-touch/pinch-zoom
    public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
    public float orthoZoomSpeed = 0.5f;        // The rate of change of the orthographic size in orthographic mode.
    public float Mvmt = 0.5f;
    int tapCount = 0;
    float doubleTapTimer = 0f;

    void Update()
    {
        /*
        // ------------------------------------------------------------------
        // TRANSLATION (with 3 fingers)
        // ------------------------------------------------------------------

        if (Input.touchCount == 3)
        {
            Touch touch = Input.GetTouch(0);

            float DeltaX = touch.deltaPosition.x;
            float DeltaZ = touch.deltaPosition.y;

            Camera camera = GetComponent<Camera>();

            if (Mathf.Abs(DeltaX) > Mathf.Abs(DeltaZ)) DeltaZ = 0;
            else DeltaX = 0;

            //camera.transform.position = new Vector3(camera.transform.position.x + DeltaX,
            //                                        camera.transform.position.y,
            //                                        camera.transform.position.z + DeltaZ);
            if (DeltaX != 0)
                camera.transform.Translate(Vector3.left * DeltaX);
            if (DeltaZ != 0)
                camera.transform.Translate(Vector3.down * DeltaZ);
        }
        */

        // ------------------------------------------------------------------
        // ROTATION (with 1 finger)
        // ------------------------------------------------------------------

        // If there are 1 touches on the device...
        if (Input.touchCount == 1)
        {

            Touch touch = Input.GetTouch(0);

            Camera camera = GetComponent<Camera>();

            //-------------------------------------------
            // Addempt to reinitiate camera with a double touch. Do not work
            /*
            //https://answers.unity.com/questions/1195308/how-to-detect-a-double-tap-touch-gesture.html
            
            if (Input.GetTouch(0).phase == TouchPhase.Began) tapCount++;
            //if (tapCount > 0)
                doubleTapTimer += Time.deltaTime;
            if (tapCount == 2 )
            {
                // Reinitialisation of the camera properties
                camera.transform.position = new Vector3(40f, 150f, 0f);
                camera.transform.rotation = new Quaternion(72f, 0f, 0f, 0f);
                camera.transform.rotation = Quaternion.Euler(72, 0, 0);
                camera.fieldOfView = 40f;

                doubleTapTimer = 0.0f;
                tapCount = 0;
            }
            if (doubleTapTimer > 0.15f)
            {
                doubleTapTimer = 0f;
                tapCount = 0;
            }
            */
            //-------------------------------------------
            float DeltaX = touch.deltaPosition.x;
            float DeltaZ = touch.deltaPosition.y;

            if (Mathf.Abs(DeltaX) > Mathf.Abs(DeltaZ))
                camera.transform.Rotate(0, 0.1f * DeltaX, 0);
            else
                camera.transform.Rotate(0.1f * DeltaZ, 0, 0);

            /* Addempt to clamp the 1 finger rotations. Do not work.
            float x = camera.transform.rotation.eulerAngles.x;
            float y = camera.transform.rotation.eulerAngles.y;
            float z = camera.transform.rotation.eulerAngles.z;

            y = Mathf.Clamp(y, -45, 45);
            x = Mathf.Clamp(x, 45, 135);

            camera.transform.rotation = Quaternion.Euler(x, y, z);
            */
        }

        // If there are two touches on the device...
        else if (Input.touchCount == 2)
        {

            // Store both touches.
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // https://wiki.unity3d.com/index.php/DetectTouchMovementhttps://wiki.unity3d.com/index.php/DetectTouchMovement

            Camera camera = GetComponent<Camera>();

            Vector2 vectZero = touchZero.position - touchZero.deltaPosition;
            Vector2 vectOne = touchOne.position - touchOne.deltaPosition;
            float MultMag = vectZero.magnitude * vectOne.magnitude;

            // ------------------------------------------------------------------
            // Translation (with 2 fingers)
            // ------------------------------------------------------------------

            if (Vector3.Dot(vectZero, vectOne) > MultMag - 10000 &&
                Vector3.Dot(vectZero, vectOne) < MultMag + 10000)
            {

                Touch touch = Input.GetTouch(0);

                float DeltaX = touch.deltaPosition.x;
                float DeltaZ = touch.deltaPosition.y;

                if (Mathf.Abs(DeltaX) > Mathf.Abs(DeltaZ)) DeltaZ = 0;
                else DeltaX = 0;

                //camera.transform.position = new Vector3(camera.transform.position.x + DeltaX,
                //                                        camera.transform.position.y,
                //                                        camera.transform.position.z + DeltaZ);
                if (DeltaX != 0) camera.transform.Translate(Vector3.left * 0.1f * DeltaX);
                if (DeltaZ != 0) camera.transform.Translate(Vector3.down * 0.1f * DeltaZ);

                float x = camera.transform.position.x;
                float y = camera.transform.position.y;
                float z = camera.transform.position.z;

                // To limit camera position on x y and z axes                     
                if (camera.transform.position.x < 0f)
                    camera.transform.position = new Vector3(  0f, y, z);
                else if (camera.transform.position.x > 100f)
                    camera.transform.position = new Vector3(100f, y, z);

                if (camera.transform.position.y < 10f)
                    camera.transform.position = new Vector3(x,  10f, z);
                else if(camera.transform.position.y > 150f)
                    camera.transform.position = new Vector3(x, 150f, z);

                if (camera.transform.position.z < -10f)
                    camera.transform.position = new Vector3(x, y, -10f);
                else if(camera.transform.position.z > 100f)
                    camera.transform.position = new Vector3(x, y, 100f);
            }

            else
            {
                // ------------------------------------------------------------------
                // ROTATION (with 2 fingers)
                // ------------------------------------------------------------------

                float turnAngle = Angle(touchZero.position, touchOne.position);
                float prevTurn = Angle(touchZero.position - touchZero.deltaPosition,
                                       touchOne.position - touchOne.deltaPosition);
                float turnAngleDelta = Mathf.DeltaAngle(prevTurn, turnAngle);

                Quaternion desiredRotation = transform.rotation;
                // float pinchAmount = 0;

                // ... if it's greater than a minimum threshold, it's a turn!
                if (Mathf.Abs(turnAngleDelta) > 0) turnAngleDelta *= Mathf.PI / 2;
                else turnAngle = turnAngleDelta = 0;

                if (Mathf.Abs(turnAngleDelta) > 0)
                { // rotate
                    Vector3 rotationDeg = Vector3.zero;
                    rotationDeg.z = -turnAngleDelta;
                    desiredRotation *= Quaternion.Euler(rotationDeg);
                }

                // not so sure those will work:
                if (desiredRotation.z > -30f && desiredRotation.z < 30f)
                {
                    camera.transform.rotation = desiredRotation;
                    //Mathf.Clamp(camera.transform.rotation.z, -30f, 30f);
                    // transform.position += Vector3.forward * pinchAmount;
                }

                // ------------------------------------------------------------------
                // PINCH ZOOM
                // ------------------------------------------------------------------

                // Find the position in the previous frame of each touch.
                Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                // Find the magnitude of the vector (the distance) between the touches in each frame.
                float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

                // Find the difference in the distances between each frame.
                float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

                // If the camera is orthographic... 
                //Camera camera = GetComponent<Camera>();
                if (camera.orthographic)
                { // SHOULD NOT BE TRUE 
                    // ... change the orthographic size based on the change in distance between the touches.
                    camera.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed;

                    // Make sure the orthographic size never drops below zero.
                    camera.orthographicSize = Mathf.Max(camera.orthographicSize, 0.1f);
                }
                else
                { // SHOULD BE THE ONE EXECUTE (Because the cam is in perspective mode)      
                  // Otherwise change the field of view based on the change in distance between the touches.
                    camera.fieldOfView += deltaMagnitudeDiff * perspectiveZoomSpeed;

                    // Clamp the field of view to make sure it's between 5 and 40.
                    camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, 2f, 40f);
                    // Remark : FoV should not be bigger because it would create fisheye like deformation.
                }
            }
        }

        else if (Movement.isRunning)
        {
            //Debug.Log("itween is running !!! ");
            GameObject j1 = GameObject.Find("Sphere_path");

            Camera camera = GetComponent<Camera>();

            float x = j1.transform.position.x;
            float y = j1.transform.position.y + 50;
            float z = j1.transform.position.z - 50;

            camera.transform.position = new Vector3(x, y, z);
            camera.transform.rotation = Quaternion.Euler(30, 0, 0);
            camera.fieldOfView = 20f;
            transform.LookAt(j1.transform);
        }
    } 

    static private float Angle(Vector2 pos1, Vector2 pos2)
    {
        // https://wiki.unity3d.com/index.php/DetectTouchMovement

        Vector2 from = pos2 - pos1;
        Vector2 to = new Vector2(1, 0);

        float result = Vector2.Angle(from, to);
        Vector3 cross = Vector3.Cross(from, to);
    
        if (cross.z > 0)
        {
            result = 360f - result;
        }
        return result;
    }
}

