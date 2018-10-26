using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DictionarySelecter : MonoBehaviour {

    [SerializeField] private GameObject Monsters;
    [SerializeField] private GameObject Selecter;
    [SerializeField] private int MonsterNumber;

    private Button button;

    public void Select()
    {
        for(int i = 0; i< Monsters.transform.childCount; i++)
        {
            if (Monsters.transform.GetChild(i).gameObject.activeSelf)
                Monsters.transform.GetChild(i).gameObject.SetActive(false);
        }

        Selecter.SetActive(true);
    }

    private void OnEnable()
    {
        button = GetComponent<Button>();

        if (UQGameManager.Instance.Monsters[MonsterNumber])
        {
            button.interactable = true;
            transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            button.interactable = false;
            transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        }
    }
}
