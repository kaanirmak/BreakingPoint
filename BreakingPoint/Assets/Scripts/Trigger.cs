using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        {
                if (collision.collider.gameObject.tag == "Card_1")
                {
                    SceneManager.LoadScene("Scene_1");
                }
                else if (collision.collider.gameObject.tag == "Card_2")
                {
                    SceneManager.LoadScene("Scene_2");
                }
            }
        }
    }
