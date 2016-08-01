using UnityEngine;
using System.Collections;

public class PlayerHandler : MonoBehaviour {

    private Rigidbody2D myRigidbody;
    [SerializeField]
    private float speed;
    private Vector2 vectorVelocity;
    public float health;
    public GameObject chocolate;

	// Use this for initialization
	void Start () {

        myRigidbody = GetComponent<Rigidbody2D>();
        vectorVelocity.x = 3;
        vectorVelocity.y = 6;
        myRigidbody.velocity = vectorVelocity;
        
	}

 
	// Update is called once per frame
    void Update()
    {
        velocityReducer();
    }

    private void velocityReducer()
    {
        vectorVelocity = myRigidbody.velocity;
       
        if (vectorVelocity.y > 0)
            vectorVelocity.y -= vectorVelocity.y / 150;
        

        if (vectorVelocity.x > 0)
            vectorVelocity.x -= vectorVelocity.x / 150;
       
        myRigidbody.velocity = vectorVelocity;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        switch (coll.gameObject.name)
        {
            case "chocolate":
                Destroy(chocolate);
                health++;
                break;

        }
    }

}
