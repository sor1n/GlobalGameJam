using UnityEngine;
using System.Collections;

public class CreateLevel : MonoBehaviour {

	public Texture2D levelfile;
	public GameObject wall;
	public GameObject floor;

	void Start () {
		for(int row = 1; row <= levelfile.width; row++){
			for(int col = 1; col <= levelfile.height; col++){
				if(levelfile.GetPixel(row,col) == new Color(0,0,0)){
					GameObject insWall = Instantiate(wall);
					insWall.transform.position = new Vector2 (row, col);
					insWall.transform.SetParent(transform);
				}else{
					GameObject insFloor = Instantiate(floor);
					insFloor.transform.position = new Vector2 (row, col);
					insFloor.transform.SetParent(transform);
				}
			}
		}
	}
	
	void Update () {
	
	}
}
