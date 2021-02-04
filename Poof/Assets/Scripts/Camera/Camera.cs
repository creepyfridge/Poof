using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform _Player = null;
    public Vector3 _Offset = new Vector3(0, 5, 10);
    public float _LookDist = 1.5f;

    public Vector2 _LookSensitivity = new Vector2(1, 1);

    // Start is called before the first frame update
    void Start()
    {
        if (_Player == null)
            Debug.LogError("player transform needs to be set");
    }

    // Update is called once per frame
    void Update()
    {
        updateRotation();
        updateZoom();
        updateFacing();        
    }

    void updateRotation()
    {
        //TODO: make this go through input manager
        Vector2 rotation = new Vector2( Input.GetAxis("Mouse X") * _LookSensitivity.x, 
                                        Input.GetAxis("Mouse Y") * _LookSensitivity.y) * Time.deltaTime;

        _Offset = Quaternion.Euler(rotation.y, rotation.x, 0.0f) * _Offset;

        transform.position = _Player.position + _Offset;
    }

    void updateFacing()
    {
        transform.LookAt(_Player.forward * _LookDist);
    }

    void updateZoom()
    {
        //TODO: use scroll wheel for zoom
        //TODO: raycast to prevent camera clipping
    }
}
