using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(BowController))]
public class Player : MonoBehaviour
{

    public float moveSpeed = 5;
    PlayerController controller;
    BowController bowController;

    Camera viewCamera;
    //public GameObject otherGameObject;

    void Start()
    {
        controller = GetComponent<PlayerController>();
        // controller = otherGameObject.GetComponent<PlayerController>();
        viewCamera = Camera.main;
        bowController = GetComponent<BowController>();
        Debug.Log("pelaaja valmiina");
    }

    // Update is called once per frame
    void Update()
    {
        //liikkuminen
        Vector3 moveimput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveimput.normalized * moveSpeed;
        controller.Move(moveVelocity);

        // näkymä
        Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundplane = new Plane(Vector3.up, Vector3.zero);
        float raydistance;

        if (groundplane.Raycast(ray, out raydistance))
        {
            Vector3 point = ray.GetPoint(raydistance);
            Debug.DrawLine(ray.origin, point, Color.red);

            controller.LookAt(point);
        }
        //aseet

        if(Input.GetMouseButton(0))
        {
            //Debug.Log("trysh to shoot");
            bowController.Shoot(this);
        }
    }
}
