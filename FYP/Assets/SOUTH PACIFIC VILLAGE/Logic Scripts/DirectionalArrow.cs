using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalArrow : MonoBehaviour
{
    playerLogic playerLogic;
    public GameObject logic;
    // Start is called before the first frame update
    [SerializeField]
    private Transform [] target;
    // Update is called once per frame
    private void Awake()
    {
        playerLogic = logic.GetComponent<playerLogic>();
    }
    void Update()
    {
       
        //Vector3 transformTarget = target.transform.position;
        //transformTarget.y = transform.position.y;
        transform.LookAt(target[playerLogic.i]);

    }
}
