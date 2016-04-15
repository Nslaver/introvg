using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Planet : MonoBehaviour
{

    //public GameObject planets;
    float orbit;
    float scale;
    float maxSize = 1.2f;
    float minSize = 0.2f;
    int frequency = 360;
    float speed = 0.05f;
    int capture = 0;
    float traslation;
    //public Text DistanceText;
    Vector3 screenPos;
    public Camera mainCamera;
    //public TextMesh planetText;




    // Use this for initialization
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        orbit = this.transform.position.z;
        scale = Random.Range(minSize, maxSize);
        traslation = Random.Range(0, 2*Mathf.PI);
        this.transform.localScale = new Vector3(scale,scale,scale);
        //planetText = Instantiate<TextMesh>(planetText);
        //this.planetText.transform.rotation = mainCamera.transform.rotation;
        //text.GetComponent<GUIText>();
        //text.text = "TEST";
        //text.fontSize = 1000;
        //Text tempTextBox = Instantiate(DistanceText, pos, rot) as Text;
        //tempTextBox.transform.SetParent(renderCanvas.transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        float pos = (maxSize - scale) * (Time.realtimeSinceStartup % frequency) * speed;
        this.transform.position = new Vector3(orbit*Mathf.Sin(pos+ traslation), 0, orbit * Mathf.Cos(pos+ traslation));
        //this.planetText.transform.position = this.transform.position;
        //text.text = "" + capture;
        //text.transform.position =this.transform.position+ new Vector3(5,5,5);
        //Guit
        //this.transform.Rotate(Vector3.forward * 0.1f);
    }

    void OnGUI()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        screenPos = mainCamera.WorldToScreenPoint(this.transform.position);        
        GUI.Label(new Rect(screenPos.x, Screen.height-screenPos.y, 100, 20), "X:" + string.Format("{0:0.##}", this.transform.position.x) + " Z:" + string.Format("{0:0.##}", this.transform.position.z));
    }
}