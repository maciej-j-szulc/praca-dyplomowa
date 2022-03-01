using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 30f;
    bool jump = false;
    public Transform cameraPosition;

    // Update is called once per frame
    void Update()
    {
        

        if(Input.touchCount > 0)
        {
            jump = true;
            animator.SetBool("isJumping", true);
            
        }
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }
    private void FixedUpdate()
    {
        controller.Move(runSpeed * Time.deltaTime, jump);
        jump = false;

        if(GetComponent<Rigidbody2D>().transform.position.y <= -2)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }


}
