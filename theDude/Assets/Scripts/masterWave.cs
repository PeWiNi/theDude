using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class masterWave : MonoBehaviour
{

    Vector3 enlarge = new Vector3(1f, 1f, 1f);
    Vector3 shrink = new Vector3(1f, 1f, 1f);
    public GameObject lavaWaves;
    GameObject panel;
    Image img;
    public environmentChanger env;
    //waves[] wvs;

    public GameObject camera_FIRE;
    public GameObject camera_RAIN;

    // Use this for initialization
    void Awake()
    {
        lavaWaves = GameObject.Find("lavaWaves");
        env = GameObject.Find("envChanger").GetComponent<environmentChanger>();
        //wvs = gameObject.GetComponents<waves> ();
    }

    void Start()
    {
        panel = GameObject.Find("Panel");
        img = panel.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {


        if (env.raining)
        {
            //shrinking the lava wave
            if (lavaWaves.transform.localScale.y > 0.01f)
            {
                if (camera_FIRE.GetComponent<AudioSource>().volume > 0f && camera_FIRE.GetComponent<AudioSource>().isPlaying)
                    camera_FIRE.GetComponent<AudioSource>().volume -= 0.01f;
                else if (camera_FIRE.GetComponent<AudioSource>().volume == 0f)
                {
                    camera_FIRE.GetComponent<AudioSource>().Stop();
                    camera_FIRE.GetComponent<AudioSource>().volume = 1f;
                }

                lavaWaves.transform.localScale = new Vector3(lavaWaves.transform.localScale.x,
                lavaWaves.transform.localScale.y - environmentChanger.noDrops / 1000000f,
                lavaWaves.transform.localScale.z);
            }
            else
            {
                //enlarge the water wave
                enlarge = new Vector3(transform.localScale.x,
                    transform.localScale.y + environmentChanger.noDrops / 10000000f,
                    transform.localScale.z);
                gameObject.transform.localScale = enlarge;
                Vector3 newPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                gameObject.transform.position = newPos;
            }
        }
        else
            //shrink the water wave
            if (environmentChanger.noFlames >= 0 && transform.localScale.y > 0.01f)
            {
                if (camera_RAIN.GetComponent<AudioSource>().volume > 0f && camera_RAIN.GetComponent<AudioSource>().isPlaying)
                    camera_RAIN.GetComponent<AudioSource>().volume -= 0.01f;
                else if (camera_RAIN.GetComponent<AudioSource>().volume == 0f)
                {
                    camera_RAIN.GetComponent<AudioSource>().Stop();
                    camera_RAIN.GetComponent<AudioSource>().volume = 1f;
                }
                
                shrink = new Vector3(transform.localScale.x,
                        transform.localScale.y - environmentChanger.noFlames / 1000000f,
                        transform.localScale.z);
                gameObject.transform.localScale = shrink;
                Vector3 newPos = new Vector3(gameObject.transform.position.x,
                        gameObject.transform.position.y, //- environmentChanger.noFlames / 100000f,
                    //	-1.55f,
                        gameObject.transform.position.z);
                gameObject.transform.position = newPos;
            }
        if (img.enabled == true)
            Destroy(gameObject);
    }
}
