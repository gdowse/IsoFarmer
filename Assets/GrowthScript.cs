using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthScript : MonoBehaviour {

    public float TimeGrowing;
	// Use this for initialization
	void Start () {
        StartCoroutine(Example());
	}
	
	// Update is called once per frame
	void Update () {
        //TimeGrowing += 1 * Time.deltaTime;
        if(Input.GetKey(KeyCode.T)){
            TimeGrowing++;
        }
            
	}

    IEnumerator Example() {
        while(TimeGrowing < gameObject.GetComponent<ItemClass>().GrowTime2){
            yield return new WaitForSeconds(5);
            TimeGrowing++;
            if(TimeGrowing == gameObject.GetComponent<ItemClass>().GrowTime1){
                gameObject.GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<ItemClass>().GrowthLevel2;
            }
            if(TimeGrowing == gameObject.GetComponent<ItemClass>().GrowTime2){
                gameObject.GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<ItemClass>().GrowthLevel3;
            }
        }
            
    }
}
