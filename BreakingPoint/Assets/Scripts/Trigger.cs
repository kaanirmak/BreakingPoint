using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public AudioSource audioSource; // AudioSource bileþenini baðlamak için bu deðiþkeni kullanýyoruz
    public AudioClip soundClip; // Çalýnacak müzik için AudioClip tanýmlýyoruz
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
        // Müziði çal
        audioSource.clip = soundClip;
        audioSource.Play();

        // 2 saniye bekle
        yield return new WaitForSeconds(2f);

        // Belirtilen sahneyi yükle
        SceneManager.LoadScene(sceneName);
    }
}
