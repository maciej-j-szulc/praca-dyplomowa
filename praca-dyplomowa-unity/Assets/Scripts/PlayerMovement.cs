using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 30f;
    bool jump = false;
    float horizontalMove = 0f;
    public Transform cameraPosition;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.deltaTime, jump);
        jump = false;
        
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }
}
