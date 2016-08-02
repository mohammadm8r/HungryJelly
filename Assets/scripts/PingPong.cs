using UnityEngine;
using System.Collections;

public class PingPong : MonoBehaviour {

    private Rigidbody2D myRigidbody;
    
	// Use this for initialization
	void Start () {
        myRigidbody = this.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
        myRigidbody.transform.position = new Vector2(Mathf.PingPong(Time.time * 3, 3.5f), myRigidbody.transform.position.y);
	}
}
