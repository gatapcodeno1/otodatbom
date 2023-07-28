using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    protected Rigidbody2D rigidbody2D1;

    public Vector2 velocity = new Vector2(0f, 0f);
    public float pressHorizontal = 0f;
    public float pressVertical = 0f;

    public float MaxSpeed = 20f;
    public float SpeedUp = 0.5f;
    public float SpeedDown = 0.5f;
    public float SpeedHorizontal = 5f;
    public bool autoRun = false;

    private void Update()
    {
        this.pressVertical = Input.GetAxis("Vertical");
        this.pressHorizontal = Input.GetAxis("Horizontal");
        if (this.autoRun) this.pressVertical = 1;

    }

    private void Awake()
    {
        this.rigidbody2D1= GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        this.UpdateSpeed();
    }

    protected virtual void UpdateSpeed()
    {
        this.velocity.x = this.pressHorizontal * SpeedHorizontal;

        if(this.pressVertical > 0f)
        {
            this.velocity.y += SpeedUp;
        }
        if(this.velocity.y > this.MaxSpeed)
        {
            this.velocity.y = this.MaxSpeed;
        }
        if(this.pressVertical == 0)
        {
            this.velocity.y -= SpeedDown;
            if(this.velocity.y < 0)
            {
                this.velocity.y = 0;
            }
        }
        if(this.transform.position.x < -7 || this.transform.position.x > 7)
        {
            this.velocity.y -= 1f;
            if(this.velocity.y < 3f)
            {
                this.velocity.y = 3f;
            }
        }


        this.rigidbody2D1.MovePosition(this.rigidbody2D1.position+ this.velocity * Time.fixedDeltaTime);
    }

}
