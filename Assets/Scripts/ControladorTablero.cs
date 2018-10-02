using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTablero : MonoBehaviour {


    public float velocidad = 20;

	void Update () {

        ControlarTablero();
     
    }


    void ControlarTablero(){

        if (Input.GetKey(KeyCode.W))
        {
            if (transform.rotation.x > 0.15)
            {

                transform.Rotate(0, 0, 0);

            }
            else
            {

                transform.Rotate(velocidad * Time.deltaTime, 0, 0);

            }

        }

        else if (Input.GetKey(KeyCode.S))
        {

            if (transform.rotation.x < -0.15)
            {

                transform.Rotate(0, 0, 0);

            }
            else
            {

                transform.Rotate(-velocidad * Time.deltaTime, 0, 0);

            }

        }
        else if (Input.GetKey(KeyCode.A))
        {

            if (transform.rotation.z > 0.15)
            {

                transform.Rotate(0, 0, 0);

            }
            else
            {

                transform.Rotate(0, 0, velocidad * Time.deltaTime);

            }

        }
        else if (Input.GetKey(KeyCode.D))
        {

            if (transform.rotation.z < -0.15)
            {

                transform.Rotate(0, 0, 0);

            }
            else
            {

                transform.Rotate(0, 0, -velocidad * Time.deltaTime);

            }

        }


    }
}
