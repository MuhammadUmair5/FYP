using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class playerLogic : MonoBehaviour
{
    public TMP_Text dynamic;
    public GameObject player;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        dynamic = FindObjectOfType<TMP_Text>();
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "A")
        {
            Debug.Log("A collected");
            dynamic.text = "A";
            i = i + 1;
        }
        else if(other.tag == "P")
        {
            Debug.Log("P collected");
            dynamic.text = "P";
            i = i + 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
