using UnityEngine;
using UnityEngine.UI;

public class UpdateInstruction : MonoBehaviour
{
    public Text instructionText; // Referencia al componente Text
    private bool pressedA = false;
    private bool pressedD = false;
    private bool spaceInstructionShown = false; // Verifica si la instrucción de espacio ya se mostró

    void Update()
    {
        // Comprobar si las teclas "A" y "D" han sido presionadas
        if (Input.GetKeyDown(KeyCode.A))
        {
            pressedA = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            pressedD = true;
        }

        // Si ambas teclas han sido presionadas, actualizar el texto
        if (pressedA && pressedD && !spaceInstructionShown)
        {
            instructionText.text = "Presiona la barra espaciadora para saltar";
            spaceInstructionShown = true;
        }

        // Comprobar si se ha presionado la barra espaciadora después de mostrar la instrucción
        if (spaceInstructionShown && Input.GetKeyDown(KeyCode.Space))
        {
            instructionText.text = "Felicidades ya sabes cómo moverte por este juego";
        }
    }
}
