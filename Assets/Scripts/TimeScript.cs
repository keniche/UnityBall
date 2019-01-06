using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {

    public Text time;
    public static float timeLimit = 30.0f;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        timeLimit = timeLimit - Time.deltaTime;
        time.text = timeLimit.ToString("f2");
	}
}
