using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeSpawn : MonoBehaviour
{
    public GameObject spawnObj;
    public GameObject checker;
    
  
    public float spawnTime;
    public  float spawnSpeed;
    public float spawnDistance;
    public bool invoker = false;

    void Start()
    {

        //while(invoker){
        //    InvokeRepeating("spawnObject", 1f, spawnTime);
        //    InvokeRepeating("spawnDIst", 1f, spawnTime);
            
        //}    
        // CancelInvoke("spawnObject");
        // CancelInvoke("spawnDIst");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnObject() {

       
         Instantiate( spawnObj, transform.position , transform.rotation);
        
        
    }

    public void spawnDIst() {
       
         Instantiate(checker, new Vector3(0,1,spawnDistance), transform.rotation);
    }

    
}
