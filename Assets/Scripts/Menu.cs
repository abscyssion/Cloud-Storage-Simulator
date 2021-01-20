using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public List<GameObject> indexes;
        private List<RectTransform> indexRects;
        private List<Image> indexImages;
    public List<GameObject> pages;

    public Sprite indexFront;
    public Sprite indexBack;

    private Color colDef;
    [SerializeField]
    private Color colBack;


    private void Awake()
    {
        indexRects = new List<RectTransform>();
        indexImages = new List<Image>();

        foreach(GameObject index in indexes)
        {
            indexRects.Add(index.GetComponent<RectTransform>());
            indexImages.Add(index.GetComponent<Image>());
        }

        colDef = indexImages[0].color;  
    }

    public void ChangeTab(int id)
    {
        foreach(Image img in indexImages)
        {
            img.sprite = indexBack;
            img.color = colBack;
        }

        Image image = indexImages[id];
        image.sprite = indexFront;
        image.color = colDef;

        foreach(GameObject page in pages)
        {
            page.SetActive(false);
        }

        pages[id].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
