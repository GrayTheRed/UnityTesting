using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public ViewSO viewData;

    public GameObject containerTop;
    public GameObject containerMiddle;
    public GameObject containerBottom;

    private Image imageTop;
    private Image imageMiddle;
    private Image imageBottom;

    private VerticalLayoutGroup verticalLayoutGroup;
    // Start is called before the first frame update
    private void Awake()
    {
        Init();
    }

    public void Init() 
    {
        Setup();
        Configure();
    }

    public void Setup()
    {
        verticalLayoutGroup = GetComponent<VerticalLayoutGroup>();
        imageTop = containerTop.GetComponent<Image>();
        imageMiddle = containerMiddle.GetComponent<Image>();
        imageBottom = containerBottom.GetComponent<Image>();
    }

    public void Configure()
    {
        verticalLayoutGroup.padding = viewData.padding;
        verticalLayoutGroup.spacing = viewData.spacing;
    }

    private void OnValidate()
    {
        Init();
    }
}
