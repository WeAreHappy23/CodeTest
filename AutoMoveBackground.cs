using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveBackground : MonoBehaviour {

    [SerializeField] private Transform Other;

	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.left * Time.deltaTime * 0.1f);

        if(transform.position.x < -4.65f)
        {
            transform.position = new Vector3(transform.position.x + 9.3f, transform.position.y, transform.position.z);
        }

	}
}
