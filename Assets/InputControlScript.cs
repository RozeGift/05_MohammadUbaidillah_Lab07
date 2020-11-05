using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlScript : MonoBehaviour
{

    //We will add all our references and variables here // 

    public GameObject UpCube;
    public GameObject DownCube;
    public GameObject LeftCube;
    public GameObject Rightcube;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            UpCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
           // print("Up arrow pressed");
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            UpCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
           // print("Up arrow released");
        }
        */
        if(Input.GetKeyDown(KeyCode.W))
        {
            UpCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
            print("W is pressed");
        }
        else if(Input.GetKeyUp(KeyCode.W))
        {
            UpCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
            print("W is released");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            DownCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
            print("S is pressed");
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            DownCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
            print("S is released");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            LeftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
            print("A is pressed");
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            LeftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
            print("A is released");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Rightcube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
            print("D is pressed");
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            Rightcube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
            print("D is released");
        }
    }
}
