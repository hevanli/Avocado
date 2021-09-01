using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitpointUI : MonoBehaviour
{
    public Text hpText;
    [SerializeField]
    private int HP;
    [SerializeField]
    private int maxHP;
    public Image hpBar;

    private void OnValidate()
    {
        pHP = HP;
        pmaxHP = maxHP;
    }

    public int pHP
    {
        get { return HP; }
        set { HP = value; updateHP(); }
    }

    public int pmaxHP
    {
        get { return maxHP; }
        set { maxHP = value; updateHP(); }
    }

    // Start is called before the first frame update
    void Start()
    {
        HP = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void updateHP()
    {
        hpText.text = HP + "/" + maxHP;
        RectTransform hpBarRect = hpBar.GetComponent<RectTransform>();
        hpBarRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (float)HP / maxHP * 100);
    }
}
