using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string currentColor;
    public Material Mt;
    public GameManager GM;
    public Animator anim;

    public static bool GameIsPaused = false;

    private AudioSource playerAudio;
    public AudioClip GetClip;
    public AudioClip JumpClip;
    public AudioClip deathClip;

    public bool IsSpeedUp = false;

    public float timer = 3;

    public float speed = 10f;

    private void Awake()
    {
        playerAudio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == false)
            {
                GM.PauseButton();
                GameIsPaused = true;
            }
            else
            {
                GM.QuitPauseButton();
                GameIsPaused = false;
            }
        }

        if(transform.position.y <= -5)
        {
            this.enabled = false;
            GM.OpenHItUI();
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Trap")
        {
            
            this.enabled = false;
            Debug.Log("p");
            GM.OpenHItUI();
        }

        else if (col.tag == "Speed")
        {
            Debug.Log("S");
            playerAudio.clip = JumpClip;
            playerAudio.Play();
            transform.Translate(0, speed, speed);
        }
    }
}
