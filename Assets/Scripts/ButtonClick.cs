using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonClick : MonoBehaviour
{
    public string Scene;


    public float waitTime = 3f; // Bekleme süresi (saniye cinsinden)


    public void OnButtonClick()
    {
        // Belirtilen süre kadar bekle ve sonra sahneyi yükle
        Invoke("LoadSceneAfterDelay", waitTime);
    }

    void LoadSceneAfterDelay()
    {
        // Sahneyi yükle
        SceneManager.LoadScene(Scene);
    }
}


