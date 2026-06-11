using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class text : MonoBehaviour
{

    public int textpage = 0;
    private TextMeshProUGUI textComponent;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Z))
        {
            textComponent = GetComponent<TextMeshProUGUI>();
            if (textpage == 0)
            {
                textComponent.text = "Next, the otter collected some fish and brought it to the old beggar.";
                textpage++;
            }
            else if (textpage == 1)
            {
                textComponent.text = "The jackal was too lazy to find something that the beggar could eat";
                textpage++;
            }
            else if (textpage == 2)
            {
                textComponent.text = "so he caught the first animal he could - a lizard, and placed it in front of the old beggar, along with some water";
                textpage++;
            }
            else if (textpage == 3)
            {
                textComponent.text = "The rabbit did not know what to get for the old beggar.";
                textpage++;
            }
            else
            {
                
                textpage = 4;
            }
        }*/
        if (Input.GetKeyDown(KeyCode.Z))
        {
                switch (textpage)
                {
                    case 0:
                        textComponent.text = "Next, the otter collected some fish and brought it to the old beggar.";
                        textpage++;
                        break;
                    case 1:
                        textComponent.text = "The jackal was too lazy to find something that the beggar could eat";
                        textpage++;
                        break;
                    case 2:
                        textComponent.text = "so he caught the first animal he could - a lizard, and placed it in front of the old beggar, along with some water";
                        textpage++;
                        break;
                    case 3:
                        textComponent.text = "The rabbit did not know what to get for the old beggar.";
                        textpage++;
                        break;
                    default:
                        textpage = 4;
                        break;
                }
        }
    }
}

                    /*case X:
                        textComponent.text = "";
                        textpage++;
                        break;*/