using System.Threading;
using UnityEngine;

public class Playermovement : MonoBehaviour {


    public Rigidbody rb;

    public float forwardforce = 2000f;


    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d") )
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);





        }

   
       
    }
 }