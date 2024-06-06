using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class XRPlayerMovement : MonoBehaviour
{
    public XRController leftController;
    public float speed = 1.0f;

    private XROrigin rig;
    private Vector2 inputAxis;

    void Start()
    {
        rig = GetComponent<XROrigin>();
    }

    void Update()
    {
        // Getting input from controller
        if (leftController.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis))
        {
            Move();
        }
    }

    private void Move()
    {
        // Calculating movement direction
        Vector3 direction = new Vector3(inputAxis.x, 0, inputAxis.y);
        direction = rig.Camera.transform.TransformDirection(direction);

        // Applying movement
        transform.position += speed * Time.deltaTime * direction;
    }
}
