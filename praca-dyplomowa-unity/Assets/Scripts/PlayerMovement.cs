using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 30f;
    public bool jump = false;
    public Transform cameraPosition;
    bool previousWasTouching = false;

    // Update is called once per frame
    void Update()
    {

        bool isTouching = Input.touchCount > 0;
        if(isTouching && !previousWasTouching)
        {
            jump = true;
            animator.SetBool("isJumping", true);
            Debug.Log("Działam");
        }
        previousWasTouching = isTouching;
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
