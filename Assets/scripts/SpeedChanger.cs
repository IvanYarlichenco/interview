using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChanger : MonoBehaviour
{
    // Start is called before the first frame update



    [SerializeField] cubeSpawn cube;

    
      
   
    
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * cube.spawnSpeed;
       
           
        
       
    }
   
}
