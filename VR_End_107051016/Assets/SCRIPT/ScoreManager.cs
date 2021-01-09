using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScroe;

    [Header("分數")]
    public int score;

    [Header("投進分數")]
    public int scorein = 1;

    [Header("進球音效")]
    public AudioClip soundin;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "保齡球瓶" && other.transform.position.y < 0.75f)
        {
            AddScroe();
        }
        
    }
    
    private void AddScroe()
    {
        score += scorein;
        textScroe.text =  score+ "/10";
        aud.PlayOneShot(soundin, Random.Range(1f, 10f));

    }

}
