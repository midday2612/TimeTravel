using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

   //�� ü����
    public void Change()
    {
        SceneManager.LoadScene("House");
    }
}
