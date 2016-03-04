using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Universo : MonoBehaviour {

    public GameObject planets;
    
	// Use this for initialization
	void Start () {

        //
        Vector3 pos;
        for(int i = 0; i< 9; i++)
        {
            pos = new Vector3(0,0, ((i+1)*20)+Random.Range(0, 2));
            Instantiate(planets, pos, Quaternion.identity);            
        }        
    }
	
	// Update is called once per frame
	void Update () {


	   
	}
}
