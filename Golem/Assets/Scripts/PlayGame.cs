using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    [SerializeField] GameObject theWholeShebang;
    [SerializeField] Text g;
    [SerializeField] Text o;
    [SerializeField] Text l;
    [SerializeField] Text e;
    [SerializeField] Text m;
    // Start is called before the first frame update
    IEnumerator doTheCoolThingOneLetterAtATime(){
        Color temp = g.color;
        yield return new WaitForSeconds(1.0f);
        while(temp.a < 1.0f){
            yield return new WaitForSeconds(0.01f);
            temp.a = temp.a + 0.01f;
            g.color = temp;
        }
        temp = o.color;
        while(temp.a < 1.0f){
            yield return new WaitForSeconds(0.01f);
            temp.a = temp.a + 0.01f;
            o.color = temp;
        }
        temp = l.color;
        while(temp.a < 1.0f){
            yield return new WaitForSeconds(0.01f);
            temp.a = temp.a + 0.01f;
            l.color = temp;
        }
        temp = e.color;
        while(temp.a < 1.0f){
            yield return new WaitForSeconds(0.01f);
            temp.a = temp.a + 0.01f;
            e.color = temp;
        }
        temp = m.color;
        while(temp.a < 1.0f){
            yield return new WaitForSeconds(0.01f);
            temp.a = temp.a + 0.01f;
            m.color = temp;
        }
    }

    void Start()
    {
        Color temp = g.color;
        temp.a = 0.0f;
        g.color = temp;
        o.color = temp;
        l.color = temp;
        e.color = temp;
        m.color = temp;
        theWholeShebang.SetActive(true);
        StartCoroutine(doTheCoolThingOneLetterAtATime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
