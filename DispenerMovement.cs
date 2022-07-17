using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispenerMovement : MonoBehaviour
{
    [SerializeField] float speed, widht, height;
    [SerializeField] GameObject Falour_1, Falour_2, Falour_3;
    [SerializeField] Transform targetPos;

    float timeCounter = 0f;



    void Update()
    {
        CricularMovement();
    }


    void CricularMovement()
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {

            timeCounter += Time.deltaTime * speed;

            float x = Mathf.Cos(timeCounter) * widht;
            float y = 5f;
            float z = Mathf.Sin(timeCounter)* height;

            transform.position = new Vector3(x, y, z);

            if (Input.GetKey(KeyCode.A))
            {
                Instantiate(Falour_1, targetPos.position, Quaternion.identity);

            }
            else if (Input.GetKey(KeyCode.S))
            {
                Instantiate(Falour_2, targetPos.position, Quaternion.identity);

            }
            else
            {
                Instantiate(Falour_3, targetPos.position, Quaternion.identity);

            }


        }
    }
}







   

    
        

     

