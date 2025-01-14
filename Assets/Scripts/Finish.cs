using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class Finish : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject game;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Picked")
        {
            Destroy(other.gameObject); 
            LerpMechanic.instance.cubes.Remove(other.gameObject);

            if (LerpMechanic.instance.cubes.Count==0)
            {
                Finishh();

            }

        }
    }
    private void Finishh()
    {
        text.text = ParticleGecis.instance.sayac.ToString();
        game.transform.DOMoveY(game.transform.position.y + (ParticleGecis.instance.sayac / 40), 2f);
        for (int i = 0; i < 10; i++)
        {
            if (transform.parent.name=="Level " +i )
            {
                PlayerPrefs.SetInt("levelindex", i);
            }


        }

    }
}
