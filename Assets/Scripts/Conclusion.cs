using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Conclusion : MonoBehaviour
{
    public GameObject[] personality;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.personality !=-1)
        {
            personality[GameManager.personality].SetActive(true);
        }
        else {
            Debug.Log("Personality equals to -1.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReturnClicked()
    {
        AudioManager.ButtonSound();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-3);
    }
}
