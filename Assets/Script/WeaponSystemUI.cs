using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSystemUI : MonoBehaviour
{
    public GameObject[] weaponAbilityGroup;
    public Sprite buttonActiveImage, buttonInActiveImage;
    public Image gun1, gun2, gun3, gun4;

    private void OnEnable()
    {
        for (int i = 0; i < weaponAbilityGroup.Length; i++)
        {
            if (i == GlobalValue.PickPlayerID)
            {
                DisableObj();
                ActivePanel(weaponAbilityGroup[i]);
                SetActiveBut(i);

                break;
            }
        }
    }

    void Start()
    {
        //DisableObj();
        //ActivePanel(weaponAbilityGroup[0]);
        //SetActiveBut(0);
    }

    void DisableObj()
    {
        foreach (var obj in weaponAbilityGroup)
        {
            obj.SetActive(false);
        }
    }

    void ActivePanel(GameObject obj)
    {

        obj.SetActive(true);
    }

    public void SwichPanel(GameObject obj)
    {
        for (int i = 0; i < weaponAbilityGroup.Length; i++)
        {
            if (obj == weaponAbilityGroup[i])
            {
                DisableObj();
                ActivePanel(weaponAbilityGroup[i]);
                SetActiveBut(i);
                GlobalValue.PickPlayerID = i;

                break;
            }
        }
        SoundManager.Click();
    }

    void SetActiveBut(int i)
    {
        gun1.sprite = buttonInActiveImage;
        gun2.sprite = buttonInActiveImage;
        gun3.sprite = buttonInActiveImage;
        gun4.sprite = buttonInActiveImage;

        switch (i)
        {
            case 0:
                gun1.sprite = buttonActiveImage;
                break;
            case 1:
                gun2.sprite = buttonActiveImage;
                break;
            case 2:
                gun3.sprite = buttonActiveImage;
                break;
            case 3:
                gun4.sprite = buttonActiveImage;
                break;
            default:

                break;
        }
    }
}
