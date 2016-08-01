using UnityEngine;
using System.Collections;

public class PlayerHandler : MonoBehaviour {

    private Rigidbody2D myRigidbody;
    [SerializeField]
    private float speed;
    private Vector2 vectorVelocity;

	// Use this for initialization
	void Start () {

        myRigidbody = GetComponent<Rigidbody2D>();
        vectorVelocity.x = 3;
        vectorVelocity.y = 6;
        myRigidbody.velocity = vectorVelocity;
	}
	
	// Update is called once per frame
    void update()
    {
        Debug.LogError(vectorVelocity);
    }
   
    
}
