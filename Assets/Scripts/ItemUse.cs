using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUse : MonoBehaviour
{
    public GameObject mCar;
    public Text NumOfItemText;
    public Button item_btn;
    private int items = 3;
    // Start is called before the first frame update
    void Start()
    {
        NumOfItemText.text = "아이템 수 : " + items.ToString();
        item_btn.onClick.AddListener(ItemUseFunc);

    }
    void ItemUseFunc()
    {
        if (items == 0) return;
        mCar.GetComponent<CarReflect>().reflect();
        items--;
        NumOfItemText.text = "아이템 수 : " + items.ToString();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
