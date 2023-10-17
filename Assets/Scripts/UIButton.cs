using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIButton : MonoBehaviour
{
    public void RestartBtn()
    {
        SceneManager.LoadScene("GameScene");
    }
}
