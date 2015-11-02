using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float _speed;

    private bool _canJump;
    private int _jumpCount = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))                 //Walk Forward
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.A))                //Strafe Left
        {
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.S))                //Walk Backwards
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.D))                //Strafe Right
        {
            transform.Translate(-Vector3.left * Time.deltaTime * _speed);
        }

        DoubleJump();
    }

    void DoubleJump()
    {
        if (_jumpCount < 2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
                _jumpCount++;
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            _jumpCount = 0;
        }
    }
}
