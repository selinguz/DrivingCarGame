using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle 
        //transform.Translate(0, 0, 0.1f); 
        //transform.Translate(Vector3.forward); //(0,0,1) parametrelerinin kısayollu yazımı
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
