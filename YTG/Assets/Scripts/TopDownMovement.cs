using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{

    public float Speed;
    private Animator anim;

    private bool Idle;
    private Vector2 LastMove;







    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    private void Update()
    {

        Idle = true;
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime, 0f, 0f));
            Idle = false;
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * Speed * Time.deltaTime, 0f));
            Idle = false;
        }

        anim.SetFloat("MoveX", Input.GetAxis("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxis("Vertical"));
    }









        /*
        
        if (Input.GetAxis("Horizontal") < 0)
        {
            anim.SetFloat("PlayerLeftMovement", Mathf.Abs(Input.GetAxis("Horizontal")) * -1);
        }
        else
        {
            anim.SetFloat("PlayerLeftMovement", 0);
        }





        if (Input.GetAxis("Horizontal") > 0)
        {
            anim.SetFloat("PlayerRightMovement", Mathf.Abs(Input.GetAxis("Horizontal")));
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            anim.SetFloat("PlayerDownMovement", Mathf.Abs(Input.GetAxis("Vertical")) * -1);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            anim.SetFloat("PlayerUpMovement", Mathf.Abs(Input.GetAxis("Vertical")));
        }

        */
        



}




