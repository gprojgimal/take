using UnityEngine;
using System.Collections;

public class KeyboardExample : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-0.2f, 0, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(0.2f, 0, 0));
        }
        Debug.Log(transform.position);
    }
}
