using UnityEngine;
using UnityEngine.UI;

public class UpdateInstruction : MonoBehaviour
{
    public Text instructionText;
    private bool pressedA = false;
    private bool pressedD = false;
    private bool spaceInstructionShown = false;
    private float timer = 0f;
    private float displayTime = 3f; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            pressedA = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            pressedD = true;
        }

        if (pressedA && pressedD && !spaceInstructionShown)
        {
            instructionText.text = "Presiona la barra espaciadora para saltar";
            spaceInstructionShown = true;
            timer = displayTime;
        }
         if (spaceInstructionShown && Input.GetKeyDown(KeyCode.Space))
        {
            instructionText.text = "Felicidades ya sabes cómo moverte por este juego";
            timer = displayTime;
        }

        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                instructionText.gameObject.SetActive(false);
            }
        }
    }
}