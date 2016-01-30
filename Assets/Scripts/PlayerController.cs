using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float Speed = 0f;
	private float movex = 0f;
	private float movey = 0f;
	public float teleDistance;

	void FixedUpdate () {
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		if(Input.GetKeyDown("space")){
			GetComponent<Rigidbody2D>().transform.position = new Vector2(GetComponent<Rigidbody2D>().transform.position.x + movex*teleDistance, GetComponent<Rigidbody2D>().transform.position.y + movey*teleDistance);
		}else{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (movex * Speed, movey * Speed);
		}
	}
}
