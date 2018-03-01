using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class InventoryCS : MonoBehaviour {

    public Database data;

    public List<ItemInventory> items = new List<ItemInventory>();

    public GameObject gameObjectshow;

    public GameObject InventoryMainObject;

    public int Maxcount;

    public Camera cam;
    public EventSystem ES;

    public int CurrentID;
    public ItemInventory currentitem;

    public RectTransform MovingObject;
    public Vector3 offset;



    // Use this for initialization
    void Start()
    {
        if (items.Count == 0)
            AddGraphics();

                for(int i = 0; i < Maxcount; i++)
        // this is just for testing show input random items into most of the slots
        {
            AddItem(i, data.items[Random.Range(0, data.items.Count)], Random.Range(1, 99), 100);
        }
        UpdateInventory();
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentID != -1)
            MoveObject();

    }

    public void AddItem(int ID, ITEM item, int count, float health)
    {
        items[ID].ID = item.ID;
        items[ID].health = health;
        items[ID].count = count;
        items[ID].ItemGameObj.GetComponent<Image>().sprite = item.image;
        if (count > 1 && item.ID != 0)
            items[ID].ItemGameObj.GetComponentInChildren<Text>().text = count.ToString();
        else
            items[ID].ItemGameObj.GetComponentInChildren<Text>().text = "";
    }

    public void AddInventoryItem(int ID, ItemInventory inv_item)
    {
        items[ID].ID = inv_item.ID;
        items[ID].health = inv_item.health;
        items[ID].count = inv_item.count;
        items[ID].ItemGameObj.GetComponent<Image>().sprite = data.items[inv_item.ID].image;
        if (inv_item.count > 1 && inv_item.ID != 0)
            items[ID].ItemGameObj.GetComponentInChildren<Text>().text = inv_item.count.ToString();
        else
            items[ID].ItemGameObj.GetComponentInChildren<Text>().text = "";
    }

        public void AddGraphics()
    {

        for (int i = 0; i < Maxcount; i++)
        {
            GameObject newItem = Instantiate(gameObjectshow, InventoryMainObject.transform) as GameObject;

            newItem.name = i.ToString();

            ItemInventory II = new ItemInventory();

            II.ItemGameObj = newItem;

            RectTransform RT = newItem.GetComponent<RectTransform>();
            RT.localPosition = new Vector3(0, 0, 0);
            RT.localScale = new Vector3(0, 0, 0);
            newItem.GetComponentInChildren<RectTransform>().localScale = new Vector3(1, 1, 1);

            Button tempButton = newItem.GetComponent<Button>();

            tempButton.onClick.AddListener(delegate { SelectObject(); });

            items.Add(II);



        }
    }
    
    public void UpdateInventory()
    {
        for(int i = 0; i < Maxcount; i++)
        {
            if(items[i].ID != 0 && items[i].count > 1)
            {
                items[i].ItemGameObj.GetComponentInChildren<Text>().text = items[i].count.ToString();
            }
            else
            {
                items[i].ItemGameObj.GetComponentInChildren<Text>().text = "";
            }

            items[i].ItemGameObj.GetComponent<Image>().sprite = data.items[items[i].ID].image;
        }
    }


    public void SelectObject()
    {
        if(CurrentID == -1)
        {
            CurrentID = int.Parse (ES.currentSelectedGameObject.name);
            currentitem = CopyInventoryItem(items[CurrentID]);

            MovingObject.gameObject.SetActive(true);
            MovingObject.GetComponent<Image>().sprite = data.items[currentitem.ID].image;

            AddItem(CurrentID, data.items[0], 0,0);
        }
        else
        {
            AddInventoryItem(CurrentID, items[int.Parse(ES.currentSelectedGameObject.name)]);

            AddInventoryItem(int.Parse(ES.currentSelectedGameObject.name), currentitem);

            CurrentID = -1;


            MovingObject.gameObject.SetActive(false);
        }
    }

    public void MoveObject()
    {
        Vector3 pos = Input.mousePosition + offset;
        pos.z = InventoryMainObject.GetComponent<RectTransform>().position.z;
        MovingObject.position = cam.ScreenToWorldPoint(pos);
    }

    public ItemInventory CopyInventoryItem(ItemInventory old)
    {
        ItemInventory New = new ItemInventory();

        New.ID = old.ID;
        New.ItemGameObj = old.ItemGameObj;
        New.health = old.health;
        New.count = old.count;

        return New;
    }
}

[System.Serializable]
public class ItemInventory
{
    public int ID;
    public GameObject ItemGameObj;
    public float health;
    public int count;





}
