using UnityEngine;

public class HW2PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _Rigidbody2D;
    
    private float _xspeed; 
    private float _yspeed;

    private void Start()
    {
        _Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _xspeed = Input.GetAxis("Horizontal");
        _yspeed = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(_xspeed, 0.0f, _yspeed);
        _Rigidbody2D.AddForce(movement * 10);
    }
}
