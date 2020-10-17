using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttonAnimation : MonoBehaviour
{
    public GameObject vbBtnObj;
    public AudioSource voiceObject;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
        vbBtnObj = GameObject.Find("Button");
        voiceObject = GetComponent<AudioSource>(); vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed); vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Debug.Log("start");
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
        
        if (anim.GetBool("isPressed"))
        {
            anim.SetBool("isPressed", false);
        }
        else
        {
            anim.SetBool("isPressed", true);
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
        voiceObject.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}