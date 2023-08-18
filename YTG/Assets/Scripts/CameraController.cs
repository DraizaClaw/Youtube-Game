using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject FollowTaget;
    private Vector3 TargetPos;
    public float movespeed;

    private void Update()
    {
        TargetPos = new Vector3(FollowTaget.transform.position.x, FollowTaget.transform.position.y, -10);
        transform.position = Vector3.Lerp(transform.position, TargetPos, movespeed * Time.deltaTime);
    }





}
