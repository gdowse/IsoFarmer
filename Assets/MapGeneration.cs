using UnityEngine;
using System.Collections;

public class MapGeneration : MonoBehaviour {

	public GameObject[] TileArray = new GameObject[20];
	// Use this for initialization
	void Start () {
		GenerateMap ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GenerateMap(){
		for(int y = 0; y < 20; y++){
			for(int x = 0; x < 20; x++){
				Instantiate(TileArray[0], new Vector3((-0.5F * y) + (0.5F * x),(x * -0.25F),0), Quaternion.identity);
			}
		}
	}
}
