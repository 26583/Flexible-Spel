using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunController : MonoBehaviour
{
    Dictionary<string, int> ammoOfWeapons = new Dictionary<string, int>();
    List<string> guns = new List<string>();
    int gunSelected = 0;
    [SerializeField]
    Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        ammoOfWeapons.Add("mp5", 150);
        ammoOfWeapons.Add("m16", 60);
        ammoOfWeapons.Add("m1911", 24);
        guns.Add("mp5");
        guns.Add("m16");
        guns.Add("m1911");
        Debug.Log(guns[gunSelected]);
        uiText.text = guns[gunSelected] + ": " + ammoOfWeapons[guns[gunSelected]];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ammoOfWeapons[guns[gunSelected]] -= 1;
            Debug.Log("SHoot");
            Debug.Log(guns[gunSelected] + ": " + ammoOfWeapons[guns[gunSelected]]);
            uiText.text = guns[gunSelected] + ": " + ammoOfWeapons[guns[gunSelected]];
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (gunSelected == guns.Count -1)
            {
                gunSelected =0 ;
            }
            else
            {
                gunSelected++;
            }
            Debug.Log(guns[gunSelected]);
            uiText.text = guns[gunSelected] + ": " + ammoOfWeapons[guns[gunSelected]];
        }
    }
    void OnMouseDown()
    {
        ammoOfWeapons[guns[gunSelected]] -= 1;
        uiText.text = guns[gunSelected] + ": " + ammoOfWeapons[guns[gunSelected]];
    }
}
