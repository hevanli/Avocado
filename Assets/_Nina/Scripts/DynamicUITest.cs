using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DynamicUITest : MonoBehaviour
{
    [System.Serializable]public class DynamicUIElement
    {
        public string name;
        public UnityEvent buttonEvent;
    }

    public List<DynamicUIElement> elements = new List<DynamicUIElement>();

    // public string[] items = new string[0];
    public GameObject prefab_button;
    // public UnityEvent[] buttonEvents = new UnityEvent[0];
    public int vs = 5;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i< elements.Count; i++)
        {
            // woah more buttons
            GameObject newButton = Instantiate(prefab_button);
            newButton.transform.SetParent(this.transform,false);
            Text t = newButton.GetComponentInChildren<Text>();
            t.text = elements[i].name;

            RectTransform rt = newButton.GetComponent<RectTransform>();
            rt.anchoredPosition = new Vector2(0, i * -rt.rect.height - vs);

            newButton.SetActive(true);

            Button b = newButton.GetComponent<Button>();
            UnityEvent unityEvent = elements[i].buttonEvent;
            b.onClick.AddListener(() =>
            {
                unityEvent.Invoke();
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
