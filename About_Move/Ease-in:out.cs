using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ease-in/out : MonoBehaviour
{
	private float time;
    private const float LEAP_TIME = 2f;
    private Vector3 startPosition;
    private Vector3 endPosition;
    void Update () 
    {
	    float t = Mathf.Min (time / LEAP_TIME, 1f);
	    float leapt = (t * t) * (3f - (2f * t));
	    transform.position = Vector3.Lerp (startPosition, endPosition, leapt);
	    time += Time.deltaTime;
    }
}


