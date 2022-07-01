using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemSave : MonoBehaviour
{

    public GameObject[] level;
    public static SystemSave instance;
    private void Start()
    {
       //PlayerPrefs.DeleteAll();
       int k= PlayerPrefs.GetInt("levelindex");
        for (int i = 0; i < level.Length; i++)
        {
            if (i==k)
            {

                level[i].SetActive(true);
            }
            else
            {
                level[i].SetActive(false);
            }
        }

    }


    public void Save(int counter)
    {
        PlayerPrefs.SetInt("levelindex", counter);

    }
}
