﻿using UnityEngine;
using System.Collections;

public class environmentChanger : MonoBehaviour
{
    public GameObject camera_FIRE;
    public GameObject camera_RAIN;

    public bool raining = false;
    public float duration = 2f;
    public float durationMultiplier = 1f;
    public GameObject rainDrop;
    public GameObject rainDrop2;
    public GameObject flame1;
    public GameObject flame2;
    public float time;


    public static int noFlames = 0;

    public static int noDrops = 0;

    // Use this for initialization
    void Start()
    {
        time = Time.realtimeSinceStartup;
        StartCoroutine(addWave(10f, true));

        noFlames = 0;
        noDrops = 0;
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("raindrops : " + noDrops + " flames: " + noFlames);
    }

    public IEnumerator fillTheScreen()
    {
        float currentTime = Time.realtimeSinceStartup - time;

        durationMultiplier = durationMultiplier * currentTime / 600f + durationMultiplier;
        StartCoroutine(addWave(duration * durationMultiplier, true));
        yield return new WaitForSeconds(duration * durationMultiplier);
    }

    public IEnumerator addWave(float progress, bool goOn)
    {
        while (goOn)
        {
            yield return new WaitForSeconds(0.001f);
            progress -= 0.001f;
            if (progress < 0f)
                goOn = false;
            if (raining)
            {
                if (!camera_RAIN.GetComponent<AudioSource>().isPlaying)
                    camera_RAIN.GetComponent<AudioSource>().Play();

                int rd = (int)Random.Range(0, 100);
                Vector3 pos = new Vector3(Random.Range(-23f, 23f), 18.5f, Random.Range(0.02f, 0.03f));
                noDrops++;
                if (rd <= 50)
                    Instantiate(rainDrop, pos, Quaternion.identity);
                else
                    Instantiate(rainDrop2, pos, Quaternion.identity);

                //Kill Clouds
                //foreach (CloudScript cs in GameObject.FindObjectsOfType<CloudScript>())
                //	cs.KillMe ();
            }
            else
            {
                if (!camera_FIRE.GetComponent<AudioSource>().isPlaying)
                    camera_FIRE.GetComponent<AudioSource>().Play();

                noFlames++;
                //Debug.Log (noFlames);
                int fl = (int)Random.Range(0, 100);
                Vector3 pos = new Vector3(Random.Range(0, 2) < 1 ? Random.Range(-24.5f, -1f) : Random.Range(1f, 24.5f), -0.8f, Random.Range(0.02f, 0.03f));
                if (fl <= 50)
                    Instantiate(flame1, pos, Quaternion.identity);
                else
                    Instantiate(flame2, pos, Quaternion.identity);

            }
        }
    }
}

