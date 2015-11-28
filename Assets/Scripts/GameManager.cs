using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject goFalling; //떨어질 오브젝트 Prefab
    public static GameObject goPlayer;

    private float _delayRegen = 0.5f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    if(goFalling != null)
        {
            _delayRegen -= Time.deltaTime;
            if(_delayRegen <= 0)
            {
                _delayRegen = 0.5f;
                var gObject = Instantiate(goFalling, new Vector3(Random.Range(-5.0f, 5.0f), 5.53f, 0), new Quaternion(0, 0, 0, 0));
            }
        }
	}
}
