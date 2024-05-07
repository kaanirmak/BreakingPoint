using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public AudioSource audioSource; // AudioSource bileşenini bağlamak için bu değişkeni kullanıyoruz
    public AudioClip soundClip; // Çalınacak müzik için AudioClip tanımlıyoruz
    public GameObject Card_1;
    public GameObject Card_2;
    public string option_1; // Sahne isimleri için string değişkenler
    public string option_2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Card_2"))
        {
            Destroy(Card_1);
            StartCoroutine(PlayMusicThenLoadScene(option_1));
        }
        else if (collision.collider.CompareTag("Card_1"))
        {
            Destroy(Card_2);
            StartCoroutine(PlayMusicThenLoadScene(option_2));
        }
    }

    IEnumerator PlayMusicThenLoadScene(string sceneName)
    {
        // Müziği çal
        audioSource.clip = soundClip;
        audioSource.Play();

        // 2 saniye bekle
        yield return new WaitForSeconds(2f);

        // Belirtilen sahneyi yükle
        SceneManager.LoadScene(sceneName);
    }
}
