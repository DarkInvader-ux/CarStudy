using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float _movespeed;
    public GameObject car;
    //public Camera gameCam;
    //public Transform objcToPlace;
   // public LayerMask mask;
    //private int DesiredLane = 1;//0: left 1: middle 2:right
    //public int LaneDistance = 4;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.AddForce(0, 0, _movespeed, ForceMode.Acceleration + 5);
        float horizontal = Input.GetAxis("Horizontal");
        car.transform.Translate(horizontal, 0, 0);
    }

    

}
