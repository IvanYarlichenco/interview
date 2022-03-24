using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class startStopGame : MonoBehaviour
{
    [SerializeField] cubeSpawn buttonGet;

   

  

    public void startStop()
    {
        
        if (!buttonGet.invoker)
        {
            buttonGet.InvokeRepeating("spawnObject", 1f, buttonGet.spawnTime);
            buttonGet.InvokeRepeating("spawnDIst", 1f, buttonGet.spawnTime);
            buttonGet.invoker = true;

        }
        else {

            buttonGet.CancelInvoke("spawnObject");
            buttonGet.CancelInvoke("spawnDIst");
            buttonGet.invoker = false;

        }
    }
    public void getInfo() {
        GameObject inputSpeed = GameObject.Find("spawnSpeed");
        InputField getFieldSpeed = inputSpeed.GetComponent<InputField>();
        buttonGet.spawnSpeed = float.Parse(getFieldSpeed.text);

        GameObject inputDistance = GameObject.Find("spawnDistance");
        InputField getFieldDistance = inputDistance.GetComponent<InputField>();
        buttonGet.spawnDistance = float.Parse(getFieldDistance.text);

        GameObject inputSpawnTime = GameObject.Find("spawnTime");
        InputField getFieldSpawnTime = inputSpawnTime.GetComponent<InputField>();
        buttonGet.spawnTime = float.Parse(getFieldSpawnTime.text);


    }
}
