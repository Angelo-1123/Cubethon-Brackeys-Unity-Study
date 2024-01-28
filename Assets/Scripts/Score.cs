using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public Transform player;
    public TMP_Text m_TextComponent;

    // Update is called once per frame
    void Update()
    {
        m_TextComponent.text = player.position.z.ToString("0");        
    }
}
