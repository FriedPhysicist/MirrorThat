using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public void try_again_b()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void win_button()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
    }
    

}
