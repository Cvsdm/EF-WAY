using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer: MonoBehaviour
{
    /// <summary>
    /// If the player moves, then the camera follows
    /// Else, the camera is fixed and looks down
    /// </summary>

    public GameObject player;

    private Vector3 offset;
    private Vector3 overview;
    private Vector3 focused;

    private float playerviewX;
    private float playerviewY;
    private float playerviewZ;

    public Camera mainCam;

    float old_posX;
    float old_posZ;
    float old_posY;



    void Start()
    {
        //offset = transform.position - player.transform.position;
        mainCam = Camera.main;
        mainCam.transform.position = overview;
        playerviewX = player.transform.position.x;
        playerviewY = player.transform.position.y;
        playerviewZ = player.transform.position.z;



        playerviewY = playerviewY + 7;
        playerviewZ = playerviewZ - 8;
        Debug.Log(playerviewX + "  " + playerviewY + "  " + playerviewZ);
        overview = new Vector3(-356f, 59.14f, 69.83f);
        offset = new Vector3(playerviewX, playerviewY, playerviewZ);

        old_posX = player.transform.position.x;
        old_posY = player.transform.position.y;
        old_posZ = player.transform.position.z;

    }

    
    void Update()
    {
        if (old_posX != player.transform.position.x || old_posY != player.transform.position.y || old_posZ != player.transform.position.z)
        {

            //   mainCam.transform.position = focused;
            

            Debug.Log("hello");

            transform.position = player.transform.position + offset;
        }


        else
        {
            
            mainCam.transform.position = overview;
            Debug.Log("wazza");
        }


        old_posX = player.transform.position.x;
        old_posY = player.transform.position.y;
        old_posZ = player.transform.position.z;
    }
    

}

