//floating point variable to store the player's speed
public float speed;


//store a reference to Rigidbody2D component required for 2D physics
private Rigidbody2D rb2d;

//initialization
void Start(){

    //get and store reference to the Rigidbody2D component 
    rb2d = GetComponent<Rigidbody2D> ();
}

//fixedupdate is called at a fixed interval and is dependent of frame rate. put physics here.
void FixedUpdate()
{
    //store the current horizontal input in the float moveHorizontal
    float moveHorizontal = Input.GetAxis ("Horizontal2");

    //store the current vertical input in the float moveVertical
    float moveVertical = Input.GetAxis ("Vertical2");

    //use the two store floats to create a new Vector2 variable movement
    Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

    //call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player
    rb2d.AddForce (movement * speed);
}
