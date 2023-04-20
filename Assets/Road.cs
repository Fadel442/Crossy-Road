using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : Terrain
{
    [SerializeField] Car carPrefab;
    [SerializeField] float minSpawnInterval;
    [SerializeField] float maxSpawnInterval;

    float timer;

    Vector3 carSpawnPosition;
    Quaternion carRotation;
    private void Start()
    {
        if (Random.value > 0.05f)
        {
            carSpawnPosition = new Vector3(
                horizontalSize / 2 + 10,
                 0,
                 this.transform.position.z);

            carRotation = Quaternion.Euler(0, -90, 0);
        }
        else
        {
            carSpawnPosition = new Vector3(
                -(horizontalSize / 2 + 10),
                0,
                this.transform.position.z);

            carRotation = Quaternion.Euler(0, 90, 0);

        }
    }

    private void Update()
    {
        if (timer < 0)
        {
            timer = Random.Range(minSpawnInterval, maxSpawnInterval);

            var car = Instantiate(
                carPrefab,
                carSpawnPosition,
                carRotation);

            car.SetUpDistanceLimit(horizontalSize + 30);

            return;
        }

        timer -= Time.deltaTime;
    }
}
