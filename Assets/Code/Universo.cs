using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Universo : MonoBehaviour {

    public GameObject planets;
    public GameObject gridPrefab;
    int row = 50;
    int col = 50;

    // Use this for initialization
    void Start () {

        //
        Vector3 pos;
        for(int i = 0; i< 9; i++)
        {
            pos = new Vector3(0,0, ((i+1)*20)+Random.Range(-5, 5));
            Instantiate(planets, pos, Quaternion.identity);            
        }
        for (int r = -row; r < row; r++)
        {
            for (int c = -col; c < col; c++)
            {
                if( r == 0 && c == 0)
                {
                                       
                }
                else
                {
                    Instantiate(gridPrefab, new Vector3(5 * r, 0, 5 * c), Quaternion.identity);
                }
                
            }
        }
    }
	
	// Update is called once per frame
	void Update () {


	   
	}
}
