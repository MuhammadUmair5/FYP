using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class playerLogic : MonoBehaviour
{
    public TMP_Text dynamic;
    public TMP_Text completed;
    public GameObject player;
    public GameObject [] word;
    private bool result = false;
    private int j = 0;
    public int i = 0;
    string[] wordsarray = { "A", "P", "P", "L", "E" };
    public GameObject resultant;
    // Start is called before the first frame update
    void Start()
    {
        
        dynamic = FindObjectOfType<TMP_Text>();
        completed = FindObjectOfType<TMP_Text>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "A")
        {
            Debug.Log("A collected");
            dynamic.text = "A";
            word[j].SetActive(false);
            j = j + 1;
            i = i + 1;
            result = !result;
        }
        else if(other.tag == "P")
        {
            Debug.Log("P collected");
            dynamic.text = "P";
            i = i + 1;
            word[j].SetActive(false);
            j = j + 1;
            result = !result;
        }
        else if(other.tag == "L")
        {
            Debug.Log("L collected");
            dynamic.text = "L";
            i = i + 1;
            word[j].SetActive(false);
            j = j + 1;
            result = !result;
        }
        else if(other.tag == "E")
        {
            Debug.Log("E collected");
            dynamic.text = "E";
            i = i + 1;
            word[j].SetActive(false);
            j = j + 1;
            result = !result;
        }
        else if(other.tag == "Result")
        {
            Debug.Log("Completed");
            
            i = i + 1;
            result = !result;

        }

    }
    // Update is called once per frame
    void Update()
    {
        if (result)
        {
            resultant.gameObject.SetActive(true);
        }
        else
        {
            resultant.gameObject.SetActive(false);
        }
    }
}
