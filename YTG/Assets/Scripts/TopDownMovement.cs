using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{

    public float Speed;
    private Animator anim;

    private bool PlayerMoving;
    private Vector2 LastMove;







    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    private void Update()
    {

        PlayerMoving = false;
        if (Input.GetAxisRaw("Horizontal") < -0.1f ||Input.GetAxisRaw("Horizontal") > 0.1f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime, 0f, 0f));
            PlayerMoving = true;
            LastMove = new Vector2(Input.GetAxis("Horizontal"), 0f);
        }

        if (Input.GetAxisRaw("Vertical") < -0.1f || Input.GetAxisRaw("Vertical") > 0.1f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * Speed * Time.deltaTime, 0f));
            PlayerMoving = true;
            LastMove = new Vector2(0f, Input.GetAxis("Vertical"));
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));

        anim.SetFloat("LastMoveX", LastMove.x);
        anim.SetFloat("LastMoveY", LastMove.y);

        anim.SetBool("PlayerMoving", PlayerMoving); 
    }













}




