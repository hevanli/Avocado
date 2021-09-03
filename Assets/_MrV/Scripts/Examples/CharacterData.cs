using NonStandard.Data;
using NonStandard.Data.Parse;
using UnityEngine;

public class CharacterData : MonoBehaviour {

    [TextArea(3, 10)]
    public string sourceData;

    public int strength, agility, magic;
    public string backstory;
    public float attackPower;

    void Start() {
        Tokenizer tokenizer = new Tokenizer();
        CharacterData charData = this;
        CodeConvert.TryFill(sourceData, ref charData, charData, tokenizer);
		if (tokenizer.HasError()) {
            Debug.Log(tokenizer.GetErrorString());
		}
    }
}
