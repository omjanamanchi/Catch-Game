using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public Text Score;
    int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        Score.text = "Score: " + points.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if(points == 10)
        {
            Debug.Log("Game Over – Press Space to Quit");
            if (Input.GetKey(KeyCode.Space))
            {
                Application.Quit();
            }
        }
       
       Score.text = "Score: " + points.ToString();
        
    }

    public void OnCollisionEnter(Collision other)
    {
            if (other.gameObject.name == "Asteroid 1 Variant(Clone)")
            {
                Destroy(other.gameObject);
                points++;
            }
    }
}
