using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class minigameenter : MonoBehaviour
{
    public string scenename;
    public bool istriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if  (istriggered && Input.GetKeyDown (KeyCode.E)){
        SceneManager.LoadScene(scenename);
}
    }
     void OnTriggerEnter2D()
    {
        istriggered = true;
    }
void OnTriggerExit2D()
    {
        istriggered = false;
    }
}
