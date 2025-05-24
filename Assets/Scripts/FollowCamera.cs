using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //cameras position should be the same as car's position
    [SerializeField] GameObject gameObject;
    void LateUpdate()
    {
        this.transform.position = gameObject.transform.position + new Vector3(0,0,-10);
    }
}
