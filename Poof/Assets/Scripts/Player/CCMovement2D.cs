using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using myInput;

using System;

[RequireComponent(typeof(CharacterController))]
public class CCMovement2D : ShadowTarget
{
    CharacterController _controller = null;
    float _speed = 0.0f;
    
    [SerializeField]
    float maxSpeed = 20.0f;
    [SerializeField]
    [Range(0.0f,1.0f)]
    float instantSpeed = 0.7f;
    [SerializeField]
    float accelTime = 1.5f;

    [SerializeField]
    float passiveStopSpeed = 0.35f;

    [SerializeField]
    float gravity = 9.8f;
    [SerializeField]
    float terminalVelocity = 30.0f;

    float lastInputX = 0.0f;


    int shadowID = -1;

    // Start is called before the first frame update
    void Start()
    {
        _controller = gameObject.GetComponent<CharacterController>();
        if (_controller == null)
            Debug.LogError("missing character controller on player");
    }

    // Update is called once per frame
    void Update()
    {
        if(shadowID != -1)
            ShadowManager.Instance.record(shadowID, new Tuple<DateTime, Vector3>(DateTime.Now, transform.position));

        if (isGrounded())
            groundedMovement();
        else
            airborneMovement();

        _controller.Move(new Vector3(0, 0, _speed) * Time.deltaTime);
        transform.position = new Vector3(0.0f, transform.position.y, transform.position.z);
    }

    //needed because the character crontroller grounded check can fail
    bool isGrounded()
    {
        return true;
    }

    void groundedMovement()
    {
        //-1.0 <-> 1.0
        //left <-> right
        float input = InMan.getHorizontal();

        if (lastInputX != input && input != 0.0f)
        {
            //direction change/started moving
            _speed = maxSpeed * instantSpeed * input;
        }
        else if(input != 0)
        {
            //player is holding button
            _speed += (maxSpeed/(accelTime)) * Time.deltaTime * input;
            _speed = Mathf.Clamp(_speed, -maxSpeed, maxSpeed);
        }
        else if(_speed != 0.0f)
        {
            //not moving/stopping
            float slow = passiveStopSpeed * Time.deltaTime;
            if (_speed < 0.0f)
                slow *= -1.0f;
            _speed -= slow;

            if (Mathf.Abs(_speed) < Mathf.Abs(slow))
                _speed = 0.0f;
        }
        lastInputX = input;
    }

    void airborneMovement()
    {

    }

    void applyGravity()
    {

    }

    void jump()
    {

    }

    public override void registerShadow(int id)
    {
        shadowID = id;
    }
}
