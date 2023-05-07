using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    [SerializeField] Bird bird;
    [SerializeField] Doragon doragon;
    [SerializeField] float initialTimer = 10;

    float timer;
    void Start()
    {
        timer = initialTimer;
        bird.gameObject.SetActive(false);
    }

    void Update()
    {
        if (timer <= 0 && bird.gameObject.activeInHierarchy == false)
        {
            bird.gameObject.SetActive(true);
            bird.transform.position = doragon.transform.position + new Vector3(0, 0, 13);
            //doragon.SetMoveable(false);
        }

        timer -= Time.deltaTime;        
    }

    public void ResetTimer()
    {
        timer = initialTimer;
    }
}
