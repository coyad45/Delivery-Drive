using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //this things position (camera) should be the same as the cars position
    [SerializeField] GameObject thingToFollow;
    // Update is called once per frame
    void Update()
    {
       transform.position = thingToFollow.transform.position+ new Vector3(0,0,-10);
    }
}
