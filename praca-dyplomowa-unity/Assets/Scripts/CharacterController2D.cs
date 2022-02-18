using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float JumpForce = 350f;
    [Range(0, .3f)] [SerializeField] private float MovementSmoothing = .05f;
    [SerializeField] private LayerMask WhatIsGround;
    [SerializeField] private Transform GroundCheck;

    const float GroundedRadius = 0.2f;
    private bool Grounded;
    private Rigidbody2D p_Rigidbody2D;
    private Vector3 Velocity = Vector3.zero;
    private float timeBeforeGroundCheck = 0f;

    [Header("Events")]
    public UnityEvent OnLandEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }

    public void Awake()
    {
        p_Rigidbody2D = GetComponent<Rigidbody2D>();

        if (OnLandEvent == null)
            OnLandEvent = new UnityEvent();
    }

    // Update is called once per frame
    private void Update()
    {
        if(!Grounded)
        {
            timeBeforeGroundCheck -= Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        if(timeBeforeGroundCheck > 0f)
        {
            return;
        }
        bool wasGrounded = Grounded;
        Grounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(GroundCheck.position, GroundedRadius, WhatIsGround);
        for( int i = 0; i < colliders.Length; i++)
        {
            if(colliders[i].gameObject != gameObject)
            {
                Grounded = true;
                if (!wasGrounded)
                    OnLandEvent.Invoke();
            }
        }
    }

    public void Move(float move, bool jump)
    {
        if(Grounded)
        {
            Vector3 targetVelocity = new Vector2(move, p_Rigidbody2D.velocity.y);
            p_Rigidbody2D.velocity = Vector3.SmoothDamp(p_Rigidbody2D.velocity, targetVelocity, ref Velocity, MovementSmoothing);
        }


        if(Grounded && jump)
        {
            p_Rigidbody2D.AddForce(new Vector2(0f, JumpForce));
        }
    }
}
