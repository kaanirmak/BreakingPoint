using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public AudioSource audioSource; // AudioSource bile�enini ba�lamak i�in bu de�i�keni kullan�yoruz
    public AudioClip soundClip; // �al�nacak m�zik i�in AudioClip tan�ml�yoruz
    public GameObject Card_1;
    public GameObject Card_2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Card_1"))
        {
            Destroy(Card_1);
            StartCoroutine(PlayMusicThenLoadScene("Scene_2"));
        }
        else if (collision.collider.CompareTag("Card_2"))
        {
            Destroy(Card_2);
            StartCoroutine(PlayMusicThenLoadScene("Scene_1"));
        }
    }

    IEnumerator PlayMusicThenLoadScene(string sceneName)
    {
        // M�zi�i �al
        audioSource.clip = soundClip;
        audioSource.Play();

        // 2 saniye bekle
        yield return new WaitForSeconds(2f);

        // Belirtilen sahneyi y�kle
        SceneManager.LoadScene(sceneName);
    }
}
