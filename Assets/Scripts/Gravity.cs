using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, -0.1f));
        if(transform.position.y < -3)
        {
            Destroy(this.gameObject);
        }
	}
}
