using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class ReturnMain : MonoBehaviour
{
    public void OnReturnbuttonClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
