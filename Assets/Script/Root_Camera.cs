using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root_Camera : MonoBehaviour
{
    //The root object
    public Transform root;

    //update main camera(tranform) position to root position with Z of -10
    //z of -10, is because Unity operates 2d space within a 3 dimenisonal space,
    //with z being the layer of objects
    void LateUpdate()
    {
        transform.position = root.transform.position+ new Vector3(0,0,-10);
    }
}
