using UnityEngine;
using System.Collections;

public class BasicEnemyController : MonoBehaviour {

	public Transform target;
	public float Speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 velocity = new Vector2 ((transform.position.x - target.position.x) * Speed, (transform.position.y - target.position.y) * Speed);
		GetComponent<Rigidbody2D>().velocity =- velocity;
	}

}
