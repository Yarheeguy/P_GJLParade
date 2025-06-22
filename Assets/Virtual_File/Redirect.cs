using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Redirect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public async void Awake()
    {
       await Task.Delay(3000); // Wait for 1 second before loading the scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }
}
