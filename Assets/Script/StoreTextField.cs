using UnityEngine;
using UnityEngine.UI;

public class StoreTextField : MonoBehaviour
{
    [SerializeField] InputField nomEpisode;
    [SerializeField] InputField nombreVues;

    [SerializeField] Text textNomEpisode;
    [SerializeField] Text textNombreVues;

    private string valueFromField1;
    private string valueFromField2;


    // Cette fonction est appelée lorsque le bouton est cliqué
    public void OnButtonClick()
    {
        // Récupérez les valeurs des InputFields et stockez-les dans des variables
        valueFromField1 = nomEpisode.text;
        valueFromField2 = nombreVues.text;

        textNomEpisode.text = valueFromField1;
        textNombreVues.text = valueFromField2;
    }
}
