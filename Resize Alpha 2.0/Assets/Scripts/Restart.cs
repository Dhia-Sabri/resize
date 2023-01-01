using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public PlayerYeet ta7rika;
    public Transform Pos;
    public GameObject Win;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.R))
        {
            //Pos.position = new Vector3(0, 1, 0);
            //Pos.rotation = new Quaternion(0, 0, 0, 0);
            //Pos.localScale = new Vector3(1, 1, 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            ta7rika.enabled = true;            
            Win.SetActive(false);

        }

    }
}
