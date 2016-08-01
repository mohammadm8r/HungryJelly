using UnityEngine;
using System.Collections;

public class PingPong : MonoBehaviour {

    private Rigidbody2D myRigidbody;
    float health;
    public GameObject chocolate;
	// Use this for initialization
	void Start () {
        myRigidbody = this.GetComponent<Rigidbody2D>();
	}

    private void OnCollisionEnter2D(Collision2D coll)
    {
        switch(coll.gameObject.name)
        {
            case "chocolate":
            Destroy (chocolate);
			health++;
			break;

        }
    }
	// Update is called once per frame
	void Update () {
        myRigidbody.transform.position = new Vector2(Mathf.PingPong(Time.time * 3, 3.5f), myRigidbody.transform.position.y);
	}
}
