using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Transitions : MonoBehaviour
{
    public RawImage Image;
    public float alphacons;
    public float timeconst = 0;
    public GameObject CF;
    public float time = 0;
    public float duration = 0;
    public bool transition=false;
    public bool fin=false;
    public bool fout=false;
    public bool fhold = false;
    public bool tpn = false;
    public Teleport tp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Delay();
        if (fin)
        {
            duration = 3f;
            FadeIN();
        }
        if (fhold&&time>0.98f)
        {
            fhold = false;
            fin = false;
            fout = true;
            time = 0f;
            duration = 3f;
            tpn=true;

        }
        if (fout)
        {
            duration = 3f;
            FadeOUT();
        }
    }
    public void Zone0()
    {
        tp.idt = 0;
        tp.TeleportPlayer();
    }

    public void Zone1()
    {
        tp.idt = 1;
        tp.TeleportPlayer();
    }
    public void Zone2()
    {
        tp.idt = 2;
        tp.TeleportPlayer();
    }
    public void Zone3()
    {
        tp.idt = 3;
        tp.TeleportPlayer();
    }
    public void Zone4()
    {
        tp.idt = 4;
        tp.TeleportPlayer();
    }
    public void CrossFade()
    {
        time = 0;
        CF.SetActive(true);
        fin = true;

    }
    public async void FadeIN()
    {
        transition = true;
       if(alphacons<=0.99)
        {

            alphacons = (time/3);
            Image.color = new Color(0, 0, 0, alphacons);
        }
       else
        {
            fin = false;
            time = 0;
            duration= 1f;
            fhold = true;
            transition = true;
            Image.color = new Color(0, 0, 0, 2);
        }   

    }
    public async void FadeOUT()
    {
        transition = true;
        if (alphacons >= 0.02)
        {
            alphacons = ((3-time)/ 3);
            Image.color = new Color(0, 0, 0, alphacons);

        }
        else
        {
            fout = false;
            CF.SetActive(false);
            tpn=false;
            transition = false;
            tp.teleporting = false;
        }
    }
    public void Delay()
    {
        if(transition)
        {
            time += Time.deltaTime;
            if (time >duration)
            {
                transition = false;
                time = 0f;
            }
        }
    }
}
