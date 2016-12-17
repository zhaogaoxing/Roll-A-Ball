using UnityEngine;
using System.Collections;

public class FollowBall : MonoBehaviour {

    public Transform balltransform;
    public Vector3 offside;
	// Use this for initialization
	void Start () {
        offside = transform.position - balltransform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = balltransform.position + offside;
	}
}
